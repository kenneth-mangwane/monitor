using Euromonitor.BusinessObjects.Interfaces;
using Euromonitor.Data;
using Euromonitor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Euromonitor.BusinessObjects.Logic
{
    public class SubscriptionLogic: ISubscriptionLogic
    {
        private EuromonitorDbContext EuromonitorDbContext { get; set; }
        public SubscriptionLogic(EuromonitorDbContext _euromonitorDbContext)
        {
            this.EuromonitorDbContext = _euromonitorDbContext;
        }

        public Subscription Subscribe(Guid bookId, int userId)
        {
            var subscription = EuromonitorDbContext.Subcriptions.Where(s => s.BookId == bookId && s.UserId == userId).FirstOrDefault() ?? new Subscription()
            {
                BookId = bookId,
                UserId = userId
            };
            subscription.State = (int)SubscriptionEnum.Subscribe;
            EuromonitorDbContext.Add(subscription);
            EuromonitorDbContext.SaveChanges();

            return subscription;
        }
        public Subscription Unsubscribe(Guid bookId, int userId)
        {
            var subscription = EuromonitorDbContext.Subcriptions.Where(s => s.BookId == bookId && s.UserId == userId).FirstOrDefault();
            if (subscription != null)
            {
                subscription.State = (int)SubscriptionEnum.Unsubscribe;
                EuromonitorDbContext.Update(subscription);
                EuromonitorDbContext.SaveChanges();
            }
            return subscription;
        }
        public Subscription Unsubscribe(Guid subcriptionId)
        {
            var subscription = EuromonitorDbContext.Subcriptions.Where(s => s.Id == subcriptionId).FirstOrDefault();
            if (subscription != null)
            {
                subscription.State = (int)SubscriptionEnum.Unsubscribe;
                EuromonitorDbContext.Update(subscription);
                EuromonitorDbContext.SaveChanges();
            }
            return subscription;
        }

        public Subscription GetSubscription(Guid subscriptionId)
        {
            return EuromonitorDbContext.Subcriptions.Find(subscriptionId);
        }

        public Subscription GetSubscription(Guid bookId, int userId)
        {
            return EuromonitorDbContext.Subcriptions.Where(s=>s.BookId ==bookId && s.UserId==userId).FirstOrDefault();
        }

        public List<Subscription> GetSubscriptions(int limit = 10, int skip = 0)
        {
            return EuromonitorDbContext.Subcriptions.Take(limit).Skip(skip).ToList();
        }
    }
}
