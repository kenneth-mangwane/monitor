using OBS.Types.Interfaces.Data.Filtering;
using OBS.Types.Models.Data.Filtering;
using OBS.Utilities.Enums;
using System.ComponentModel.Composition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.API.Filtering.Providers
{
    [Export(typeof(IFilterProvider))]
    public class XFilterProvider : IFilterProvider
    {
        public const string DEFAULTFILTERPROVIDER = "xFilter";
        public const string FILTERTYPEPARAM = "filtertype";
        public const string ALLFILTERPARAM = "allfilters";
        public const string PAGESIZEPARAM = "pagesize";
        public const string PAGENUMBERPARAM = "pagenumber";
        public const string INCLUDERPARAM = "include";
        public const string ORDERBYFIELDPARAM = "orderby";
        public const string ORDERBYDIRECTIONPARAM = "orderbydirection";
        public const string SHOWDELTEDPARAM = "showdeleted";
        public const string PARAMCONTAINSLIST = "list:";

        public string Name
        {
            get
            {
                return XFilterProvider.DEFAULTFILTERPROVIDER;
            }
        }

        public IXFilterCollection GetFilter(IEnumerable<KeyValuePair<string, string>> queryContainer)
        {
            if (queryContainer == null || queryContainer.Count() <= 0)
            {
                return null;
            }

            IXFilterCollection toreturn = new XFilterCollection();
            toreturn.FiltersAndOr = this.getValueOrDefault<FilterAndOr>(queryContainer, XFilterProvider.ALLFILTERPARAM, FilterAndOr.And);
            toreturn.PageToGet = this.getValueOrDefault<int>(queryContainer, XFilterProvider.PAGENUMBERPARAM, 0);
            toreturn.PageSize = this.getValueOrDefault<int>(queryContainer, XFilterProvider.PAGESIZEPARAM, 0);
            toreturn.Includes = this.getIncludes(queryContainer);
            toreturn.OrderByCollection = this.getOrderby(queryContainer);
            toreturn.ShowSofDeletedItems = this.getShowDeletedValue(queryContainer);

            foreach (var item in queryContainer)
            {
                if (!this.canBeAddedAsFilter(item.Key))
                    continue;

                var filterType = this.getFilterType(queryContainer, item.Key);
                this.addFiltersFromQueryParam(toreturn, filterType, item.Key, item.Value);
            }

            return toreturn;
        }

        private void addFiltersFromQueryParam(IXFilterCollection filterCollection, FilterType filterType, string key, string value)
        {
            if (value.ToUpper().StartsWith(XFilterProvider.PARAMCONTAINSLIST.ToUpper()))
            {
                value = value.Substring(XFilterProvider.PARAMCONTAINSLIST.Length);
                IEnumerable<string> list = value.Split(',');
                IXFilter parentFilter = this.createFilterObject(filterType, key, list.First());
                List<IXFilter> subfilters = new List<IXFilter>();
                foreach (var item in list.Skip(1))
                {
                    IXFilter filter = this.createFilterObject(filterType, key, item);
                    subfilters.Add(filter);
                }

                parentFilter.SubFilterAndOr = FilterAndOr.Or;
                parentFilter.SubFilters = subfilters;
                filterCollection.Filters.Add(parentFilter);
            }
            else
            {
                IXFilter filter = this.createFilterObject(filterType, key, value);
                filterCollection.Filters.Add(filter);
            }
        }

        private IXFilter createFilterObject(FilterType filterType, string key, string value)
        {
            IXFilter filter = new XFilter();
            filter.Field = key.Replace("_", ".");
            filter.SearchCriteria = value;
            filter.FilterType = filterType;

            return filter;
        }

        private bool canBeAddedAsFilter(string key)
        {
            if (key.ToLower().Contains(XFilterProvider.FILTERTYPEPARAM.ToLower()))
                return false;

            if (key.ToLower().Contains(XFilterProvider.INCLUDERPARAM.ToLower()))
                return false;

            if (key.ToLower().Contains(XFilterProvider.PAGESIZEPARAM.ToLower()))
                return false;

            if (key.ToLower().Contains(XFilterProvider.PAGENUMBERPARAM.ToLower()))
                return false;

            if (key.ToLower().Contains(XFilterProvider.ALLFILTERPARAM.ToLower()))
                return false;

            if (key.ToLower().Contains(XFilterProvider.ORDERBYDIRECTIONPARAM.ToLower()))
                return false;

            if (key.ToLower().Contains(XFilterProvider.ORDERBYFIELDPARAM.ToLower()))
                return false;

            if (key.ToLower().Contains(XFilterProvider.SHOWDELTEDPARAM.ToLower()))
                return false;

            return true;
        }

        private bool getShowDeletedValue(IEnumerable<KeyValuePair<string, string>> queryContainer)
        {
            var showDeletedParam = queryContainer.Where(qp => qp.Key.ToUpper() == XFilterProvider.SHOWDELTEDPARAM.ToUpper()).Select(qp => qp.Value).FirstOrDefault();
            if (string.IsNullOrEmpty(showDeletedParam))
            {
                return false;
            }

            bool toreturn = false;
            bool.TryParse(showDeletedParam, out toreturn);
            return toreturn;
        }

        private IList<IOrderBy> getOrderby(IEnumerable<KeyValuePair<string, string>> queryContainer)
        {
            IList<IOrderBy> toreturn = new List<IOrderBy>();
            XOrderBy defaultOrderbyDirection = this.getOrderByDirection(queryContainer, XFilterProvider.ORDERBYDIRECTIONPARAM);


            var fields = queryContainer.Where(inc =>
                                                        inc.Key.ToUpper().Contains(XFilterProvider.ORDERBYFIELDPARAM.ToUpper())
                                                        &&
                                                        !inc.Key.ToUpper().Contains(XFilterProvider.ORDERBYDIRECTIONPARAM.ToUpper())
                                        ).Select(inc => inc.Value).ToList();

            foreach (var field in fields)
            {
                string orderByDirectionForField = string.Format("{0}_{1}", XFilterProvider.ORDERBYDIRECTIONPARAM, field);
                IOrderBy toadd = new XOrderListBy
                {
                    Field = field,
                    OrderBy = this.getOrderByDirection(queryContainer, orderByDirectionForField, defaultOrderbyDirection)
                };

                toreturn.Add(toadd);
            }

            return toreturn;
        }

        private XOrderBy getOrderByDirection(IEnumerable<KeyValuePair<string, string>> queryContainer, string key, XOrderBy defaultValue = XOrderBy.Asccending)
        {
            var direction = queryContainer.Where(inc => inc.Key.ToUpper() == key.ToUpper()).Select(inc => inc.Value).FirstOrDefault();
            XOrderBy orderbyDirection = defaultValue;

            if (!string.IsNullOrEmpty(direction))
            {
                if (direction.ToUpper().Contains("ASC"))
                {
                    orderbyDirection = XOrderBy.Asccending;
                }
                else if (direction.ToUpper().Contains("DESC"))
                {
                    orderbyDirection = XOrderBy.Descending;
                }
            }

            return orderbyDirection;
        }

        private T getValueOrDefault<T>(IEnumerable<KeyValuePair<string, string>> queryContainer, string paramName, T defaultValue)
        {
            var item = queryContainer.Where(p => p.Key.ToLower() == paramName.ToLower()).FirstOrDefault();
            if (!string.IsNullOrEmpty(item.Key))
            {
                try
                {
                    return OBS.Utilities.Types.TypeConverter.ConvertType<T>(item.Value);
                }
                catch
                {
                    return defaultValue;
                }
            }

            return defaultValue;
        }

        private List<string> getIncludes(IEnumerable<KeyValuePair<string, string>> queryContainer)
        {
            List<string> toreturn = new List<string>();
            return queryContainer.Where(inc => inc.Key.ToUpper().Contains(XFilterProvider.INCLUDERPARAM.ToUpper())).Select(inc => inc.Value).ToList();
        }

        private FilterType getFilterType(IEnumerable<KeyValuePair<string, string>> queryContainer, string paramName)
        {
            FilterType filterType = FilterType.Equals;
            string key = string.Format("{0}_{1}", XFilterProvider.FILTERTYPEPARAM, paramName);

            var item = queryContainer.Where(p => p.Key.ToLower() == key.ToLower()).FirstOrDefault();
            if (!string.IsNullOrEmpty(item.Key))
            {
                try
                {
                    filterType = EnumEx.GetValueFromDescription<FilterType>(item.Value, false);
                }
                catch
                {
                    filterType = FilterType.Equals;
                }

                return filterType;
            }


            item = queryContainer.Where(p => p.Key.ToLower() == XFilterProvider.FILTERTYPEPARAM.ToLower()).FirstOrDefault();

            if (!string.IsNullOrEmpty(item.Key))
            {
                try
                {
                    filterType = EnumEx.GetValueFromDescription<FilterType>(item.Value, false);

                }
                catch
                {
                    filterType = FilterType.Equals;
                }
            }

            return filterType;
        }

    }
}