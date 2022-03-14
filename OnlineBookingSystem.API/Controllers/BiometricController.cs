using Common.Logging;
using DryIoc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using OBS.API.Models.ViewModel;
using OBS.API.Models.ViewModel.Biometric;
using OBS.Common.JQuery;
using OBS.Core.Biometric;
using OBS.Core.Biometric.Exceptions;
using OBS.Core.Biometric.Models;
using OBS.Core.Biometric.Types;
using OBS.Core.Interfaces.Biometric;
using OBS.Core.IoC;
using SP.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace OBS.API.Controllers
{
    [Route("api/biometric")]
    public class BiometricController : Controller
    {
        protected IBiometricLogic BiometricLogic { get; set; }
        protected IHostingEnvironment _hostingEnvironment;
        public BiometricController(IHostingEnvironment hostingEnvironment)
        {
            var container = ContainerRegistration.CreateContainer(rules => rules.WithoutThrowOnRegisteringDisposableTransient().With(FactoryMethod.ConstructorWithResolvableArguments));
            this.BiometricLogic = (IBiometricLogic)container.Resolve(typeof(IBiometricLogic), true);
            this._hostingEnvironment = hostingEnvironment;
        }

        [NonAction]
        public EnrollmentInformation GetEnrollmentInfo(AccountInformation accountInfo)
        {
            EnrollmentInformation enrollmentInfo = null;

            using (var context = new StagingDBEntities())
            {
                enrollmentInfo = context.GetEnrollmentInformation(accountInfo);
            }

            return enrollmentInfo;

        }

        #region [Student - Single]
        [HttpGet, Route("")]
        public ActionResult Index()
        {
            try
            {
                LogManager.GetLogger(GetType()).Info("Loading Student Biometric view");
                return View();
            }
            catch (StackOverflowException soe)
            {
                string s = soe.Message.ToString();
                throw;
            }
            catch (Exception ex)
            {
                string s = ex.Message.ToString();
                throw;
            }
        }

        [HttpPost, Route("FindStudent")]
        public JsonResult FindStudent([FromBody] FindTenantViewModel findTenantViewModel)
        {
            var toReturn = this.getCustomerLeaseEnrollmentData(null, findTenantViewModel.accountNumber, findTenantViewModel.accountName, BuildingType.Student);
            return toReturn;
        }

        [HttpPost, Route("LeaseSelectionChanged")]
        public JsonResult LeaseSelectionChanged(AccountInformation accountInformation)
        {
            string result = "Success";
            string message = string.Empty;

            LeaseEnrollmentComparer comparison = null;
            try
            {
                if (accountInformation == null || accountInformation.EnrollmentInformation == null || accountInformation.LeaseInformation == null)
                    message = "No Data found!";
                else
                    comparison = new LeaseEnrollmentComparer(accountInformation.EnrollmentInformation, accountInformation.LeaseInformation);

            }
            catch (Exception ex)
            {
                message = this.getExceptionMessage(ex);
                logException(ex);
                result = "Error";
            }
            return Json(new { Result = result, Message = message, AccountInformation = accountInformation, Comparison = comparison });
        }

        [HttpPost, Route("UpdateStudentBiometric")]
        public JsonResult UpdateStudentBiometric([FromBody]UpdateStudentBiometricViewModel updateStudentBiometricViewModel)
        {
            string result = string.Empty;
            string message = string.Empty;
            try
            {
                CurrentUser.name = updateStudentBiometricViewModel.user;
                var toReturn = this.updateBiometric(updateStudentBiometricViewModel.accountInformation, BuildingType.Student, false);
                return toReturn;
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return this.Json(new { Result = result, Message = message });
        }


        [HttpPost, Route("DeleteFromBiometric")]
        public async Task<IActionResult> DeleteFromBiometric([FromBody] DeleteFromBiometricViewModel deleteFromBiometricViewModel)
        {
            if (deleteFromBiometricViewModel.accountInformation == null)
                return this.Json(new { Result = "Error", Message = "No account information supplied" });

            var validator = new AccountInformationValidator(deleteFromBiometricViewModel.accountInformation);
            if (!validator.IsValid)
                return this.Json(new { Result = "Error", Message = validator.Message });

            var comparison = new LeaseEnrollmentComparer(deleteFromBiometricViewModel.accountInformation.EnrollmentInformation, deleteFromBiometricViewModel.accountInformation.LeaseInformation);
            if (!comparison.AllIsValid)
            {
                //updated so that error is ignored if deleting is allowed
                if (comparison.CanDelete != true)
                {
                    return this.Json(new { Result = "Error", Message = comparison.Message });
                }
            }
            string result = string.Empty;
            string message = string.Empty;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    context.DeleteBiometricEntry(deleteFromBiometricViewModel.accountInformation, BiometricEntryType.Student, deleteFromBiometricViewModel.user);
                    result = "Success";
                    message = "Entry successfully deleted from Biometric";
                }
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return this.Json(new { Result = result, Message = message });
        }

        [HttpPost, Route("GetLeasesForAccount")]
        public JsonResult GetLeasesForAccount([FromBody]GetLeasesForAccountViewModel getLeasesForAccountViewModel)
        {
            List<ORA_Lease_Select_Stud_View> studentLeases = null;
            List<LeaseInformation> toReturn = new List<LeaseInformation>();
            string result = "Success";
            string message = string.Empty;
            var buildingType = BuildingType.Student;
            if (!getLeasesForAccountViewModel.isStudent)
                buildingType = BuildingType.Residential;

            try
            {
                using (var context = new StagingDBEntities())
                {
                    var leaseDate = context.GetLeaseLoadDate(buildingType);
                    if (buildingType == BuildingType.Residential)
                    {
                        var resLeases = context.ORA_Lease_Select_Resi_View.Where(o => (o.CUSTOMER_ID == getLeasesForAccountViewModel.accountInformation.CustomerAccID || o.ATTRIBUTE1 == getLeasesForAccountViewModel.accountInformation.CustomerAccID.ToString()) && o.EXPIRATION_DATE >= leaseDate).OrderBy(o => o.EXPIRATION_DATE).ToList();
                        resLeases.ForEach(o => toReturn.Add(new LeaseInformation(o)));
                    }
                    else
                    {
                        studentLeases = context.ORA_Lease_Select_Stud_View.Where(o => (o.CUSTOMER_ID == getLeasesForAccountViewModel.accountInformation.CustomerAccID || o.ATTRIBUTE1 == getLeasesForAccountViewModel.accountInformation.CustomerAccID.ToString()) && o.EXPIRATION_DATE >= leaseDate).OrderBy(o => o.EXPIRATION_DATE).ToList();
                        studentLeases.ForEach(o => toReturn.Add(new LeaseInformation(o)));
                    }
                }
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return Json(new { Result = result, Message = message, Leases = toReturn });
        }

        #endregion

        #region [Reports]

        [HttpPost, Route("GetFingerprintReportGrid")]
        public JsonResult GetFingerprintReportGrid(string _search, int rows, int page, string sidx, string sord, string filters)
        {
            #region [Parsing grid request]

            OBS.Common.Data.Filtering.OrderType orderType = JGridHelper.GetOrderType(sord);
            //Geting Filter(s)
            OBS.Common.Data.Filtering.FilterManager filterManager = new OBS.Common.Data.Filtering.FilterManager(sidx, orderType);

            if (!(string.IsNullOrEmpty(filters)))
            {
                filterManager = JGridHelper.ParseRequest(filters, sidx, orderType);
            }

            #endregion

            JQGrid toReturn = new JQGrid();
            //Common.Response response = new Common.Response();

            using (var context = new StagingDBEntities())
            {
                //var fingerSelection = (FingerprintReprotType)fingerprintSelection;
                toReturn = context.GetNoFingerprintReportView(rows, page, filterManager);
            }

            return this.Json(toReturn);
        }

        [HttpPost, Route("GetMissingLeaseReportGrid")]
        public JsonResult GetMissingLeaseReportGrid(string _search, int rows, int page, string sidx, string sord, string filters)
        {
            #region [Parsing grid request]

            OBS.Common.Data.Filtering.OrderType orderType = JGridHelper.GetOrderType(sord);
            //Geting Filter(s)
            OBS.Common.Data.Filtering.FilterManager filterManager = new OBS.Common.Data.Filtering.FilterManager(sidx, orderType);

            if (!(string.IsNullOrEmpty(filters)))
            {
                filterManager = JGridHelper.ParseRequest(filters, sidx, orderType);
            }

            #endregion

            JQGrid toReturn = new JQGrid();
            //Common.Response response = new Common.Response();

            using (var context = new StagingDBEntities())
            {
                //var fingerSelection = (FingerprintReprotType)fingerprintSelection;
                toReturn = context.GetMissingLeaseReportView(rows, page, filterManager);
            }

            return this.Json(toReturn);
        }

        [HttpPost, Route("GetEnrolledAccountsGrid")]
        public JsonResult GetEnrolledAccountsGrid(string _search, int rows, int page, string sidx, string sord, string filters)
        {
            #region [Parsing grid request]

            OBS.Common.Data.Filtering.OrderType orderType = JGridHelper.GetOrderType(sord);
            //Geting Filter(s)
            OBS.Common.Data.Filtering.FilterManager filterManager = new OBS.Common.Data.Filtering.FilterManager(sidx, orderType);

            if (!(string.IsNullOrEmpty(filters)))
            {
                filterManager = JGridHelper.ParseRequest(filters, sidx, orderType);
            }

            #endregion

            JQGrid toReturn = new JQGrid();
            using (var context = new StagingDBEntities())
            {
                toReturn = context.GetEnrolledAccoutnsView(rows, page, filterManager);
            }

            return this.Json(toReturn);
        }

        [HttpPost, Route("GetOracleVSBiometricView")]
        public JsonResult GetOracleVSBiometricView(string _search, int rows, int page, string sidx, string sord, string filters)
        {
            #region [Parsing grid request]

            OBS.Common.Data.Filtering.OrderType orderType = JGridHelper.GetOrderType(sord);
            //Geting Filter(s)
            OBS.Common.Data.Filtering.FilterManager filterManager = new OBS.Common.Data.Filtering.FilterManager(sidx, orderType);

            if (!(string.IsNullOrEmpty(filters)))
                filterManager = JGridHelper.ParseRequest(filters, sidx, orderType);


            #endregion

            JQGrid toReturn = new JQGrid();
            using (var context = new StagingDBEntities())
            {
                toReturn = context.OracleVSBiometricView(rows, page, filterManager);
            }

            return this.Json(toReturn);
        }

        [HttpPost, Route("GetTenantActivityBetweenDates")]
        public JsonResult GetTenantActivityBetweenDates(string _search, int rows, int page, string sidx, string sord, string filters)
        {
            #region [Parsing grid request]

            OBS.Common.Data.Filtering.OrderType orderType = JGridHelper.GetOrderType(sord);
            //Geting Filter(s)
            OBS.Common.Data.Filtering.FilterManager filterManager = new OBS.Common.Data.Filtering.FilterManager(sidx, orderType);

            if (!(string.IsNullOrEmpty(filters)))
                filterManager = JGridHelper.ParseRequest(filters, sidx, orderType);


            #endregion

            JQGrid toReturn = new JQGrid();
            using (var context = new StagingDBEntities())
            {
                toReturn = context.TenantActivityBetweenDates(rows, page, filterManager);
            }

            return this.Json(toReturn);
        }

        [HttpPost, Route("GetTenantActivity")]
        public JsonResult GetTenantActivity(string _search, int rows, int page, string sidx, string sord, string filters)
        {
            #region [Parsing grid request]

            OBS.Common.Data.Filtering.OrderType orderType = JGridHelper.GetOrderType(sord);
            //Geting Filter(s)
            OBS.Common.Data.Filtering.FilterManager filterManager = new OBS.Common.Data.Filtering.FilterManager(sidx, orderType);

            if (!(string.IsNullOrEmpty(filters)))
                filterManager = JGridHelper.ParseRequest(filters, sidx, orderType);


            #endregion

            JQGrid toReturn = new JQGrid();
            using (var context = new StagingDBEntities())
            {
                toReturn = context.TenantActivity(rows, page, filterManager);
            }

            return this.Json(toReturn);
        }

        [HttpPost, Route("GetInactiveTenants")]
        public JsonResult GetInactiveTenants(string _search, int rows, int page, string sidx, string sord, string filters)
        {
            #region [Parsing grid request]

            OBS.Common.Data.Filtering.OrderType orderType = JGridHelper.GetOrderType(sord);
            //Geting Filter(s)
            OBS.Common.Data.Filtering.FilterManager filterManager = new OBS.Common.Data.Filtering.FilterManager(sidx, orderType);

            if (!(string.IsNullOrEmpty(filters)))
                filterManager = JGridHelper.ParseRequest(filters, sidx, orderType);


            #endregion

            JQGrid toReturn = new JQGrid();
            using (var context = new StagingDBEntities())
            {
                toReturn = context.InactiveTenants(rows, page, filterManager);
            }

            return this.Json(toReturn);
        }

        #endregion

        #region [Residential - Single]

        [HttpPost, Route("FindResident")]
        public JsonResult FindResident([FromBody] FindTenantViewModel findTenantViewModel)
        {
            var toReturn = this.getCustomerLeaseEnrollmentData(findTenantViewModel.idNumber, findTenantViewModel.accountNumber, findTenantViewModel.accountName, BuildingType.Residential);  // this has to use the Bioloci
            return toReturn;
        }


        [HttpPost, Route("UpdateResidentialMainTenant")]
        public JsonResult UpdateResidentialMainTenant([FromBody]UpdateResidentialMainTenantViewModel updateResidentialMainTenantViewModel)
        {
            string result = string.Empty;
            string message = string.Empty;
            bool roomConfigError = false;
            try
            {
                CurrentUser.name = updateResidentialMainTenantViewModel.user;
                var toReturn = this.updateBiometric(updateResidentialMainTenantViewModel.accountInfo, BuildingType.Residential, updateResidentialMainTenantViewModel.ignoreRommConfigError);
                return toReturn;
            }
            catch (BuildingConfigComparisonException ex)
            {
                roomConfigError = true;
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            catch (Exception ex)
            {
                roomConfigError = false;
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return this.Json(new { Result = result, Message = message, RoomConfigError = roomConfigError });
        }


        [HttpDelete, Route("DeleteMainResidentialTenant")]
        public JsonResult DeleteMainResidentialTenant([FromBody]DeleteMainResidentialTenantViewModel deleteMainResidentialTenantViewModel)
        {
            string result = string.Empty;
            string message = string.Empty;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    context.DeleteMainResidentialTenant(deleteMainResidentialTenantViewModel.accountInformation, deleteMainResidentialTenantViewModel.user);
                }
                result = "Success";
                message = "Entry successfully deleted";
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return this.Json(new { Result = result, Message = message });
        }


        [HttpPost, Route("AddSubTenant")]
        public JsonResult AddSubTenant(AccountInformation accountInfo, string LEASE_NUM, string LOCATION_CODE, string TAG_Code, string ALLOCATION_TYPE, string MST_Suffix, string MST_FirstName, string MST_LastName, string MST_ID, bool ParkingAssigned, string oper)
        {
            if (accountInfo == null)
                return this.Json(new { Result = "Error", Message = "No account information supplied" });

            var validator = new AccountInformationValidator(accountInfo);
            if (!validator.IsValid)
                return this.Json(new { Result = "Error", Message = validator.Message });

            /*var comparison = new LeaseEnrollmentComparer(accountInfo.EnrollmentInformation, accountInfo.LeaseInformation);
            if(comparison.AllIsValid && !comparison.CanUpdate)
                return this.Json(new { Result = "Success", Message = comparison.Message } );//This would mean that no action is required*/

            string result = "Sucess";
            string message = string.Empty;
            int tagCode = default(int);
            string empNo = string.Empty;
            //    Res_02_Alloc_Tens subTenant = null;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    accountInfo.EnrollmentInformation.ParkingSelected = ParkingAssigned;
                    context.TransferToBiometric(accountInfo, MST_Suffix, MST_FirstName, MST_LastName, MST_ID, out tagCode, out empNo, User.Identity.Name);
                    //var subTenants = context.LoadResidentialSubTenants(accountInfo, accountInfo.EnrollmentInformation);
                    //subTenant = subTenants.Where(o => o.TAG_Code == tagCode.ToString()).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }

            return Json(new { Result = result, Message = message, TagCode = tagCode, EmpNo = empNo });//, SubTenant = subTenant });
        }


        /// <summary>
        /// this was prevously used to delete residential subtenants
        /// </summary>
        /// <param name="accountInfo"></param>
        /// <param name="toDelete"></param>
        /// <returns></returns>
        [HttpDelete, Route("DeleteSubTenant")]
        public JsonResult DeleteSubTenant(AccountInformation accountInfo, Res_02_Alloc_Tens toDelete)
        {
            if (accountInfo == null)
                return this.Json(new { Result = "Error", Message = "No account information supplied" });

            var validator = new AccountInformationValidator(accountInfo);
            if (!validator.IsValid)
                return this.Json(new { Result = "Error", Message = "ZAZA" + validator.Message });

            if (toDelete == null || string.IsNullOrEmpty(toDelete.ACCOUNT_NUMBER))
                return this.Json(new { Result = "Error", Message = "No account information supplied for deletion" });

            string result = "Sucess";
            string message = string.Empty;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    context.DeleteSubTenant(toDelete, User.Identity.Name);
                }

            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }

            return Json(new { Result = result, Message = message });
        }

        [HttpPost, Route("ActivateDeactivateTenant")]
        public JsonResult ActivateDeactivateTenant(AccountInformation accountInfo)
        {
            string result = string.Empty;
            string message = string.Empty;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    context.ActivateDeactivateTenant(accountInfo, User.Identity.Name);
                }
                result = "Success";
                message = "Tenant successfully updated";
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return this.Json(new { Result = result, Message = message });
        }

        #endregion

        #region [Student - Multiple]

        [HttpPost, Route("LoadBuildings")]
        public JsonResult LoadBuildings(bool loadResidentialBuilding)
        {
            BUILD_01_BUILD_SITE[] toReturn = null;
            string result = "Success";
            string message = string.Empty;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    var query = context.BUILD_01_BUILD_SITE;
                    if (!loadResidentialBuilding)
                        toReturn = query.GroupBy(o => o.Building_Name, o => o, (key, buildings) => new { Name = key, Building = buildings.FirstOrDefault() }).OrderBy(o => o.Name).Select(o => o.Building).Where(o => o.Building_Type.ToLower() != "residential").ToArray();
                    else
                        toReturn = query.GroupBy(o => o.Building_Name, o => o, (key, buildings) => new { Name = key, Building = buildings.FirstOrDefault() }).OrderBy(o => o.Name).Select(o => o.Building).ToArray();

                }
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return Json(new { Result = result, Message = message, Buildings = toReturn });
        }

        [HttpPost, Route("UpdateOccupancyData")]
        public JsonResult UpdateOccupancyData()
        {
            string result = string.Empty;
            string message = string.Empty;
            try
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                using (var context = new StagingDBEntities())
                {
                    context.UpdateOccupancyData();
                }
                stopwatch.Stop();
                result = "Success";
                message = string.Format("The Occupancy data has been updated. Opperation took a total of {0} seconds", stopwatch.Elapsed.TotalSeconds);
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return Json(new { Result = result, Message = message });
        }

        [HttpPost, Route("CheckUpdateOccupancyData")]
        public JsonResult CheckUpdateOccupancyData()
        {
            string result = "Success";
            string message = string.Empty;
            Mass_Upd_Time lastSynch = null;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    //toReturn = context.EnrolledAccounts

                    lastSynch = context.Mass_Upd_Time.Where(o => o.Action_Desc == "Occ_Upd").FirstOrDefault();
                    if (lastSynch == null)
                    {
                        result = "Error";
                        message = "Occupancy Data has not been updated. Please update the Occupancy Data by clicking 'Update Occupancy Data' button";
                    }
                    else
                    {
                        message = (lastSynch.Upd_Date.HasValue ? lastSynch.Upd_Date.Value.ToString(DataModelBase.DATE_STRING_FORMAT) : "'Date Unavailable'");
                        message = string.Format("The Occupancy Data was last Updated on {0}. If you want to update the occupancy data please click on 'Update Occupancy Data' button", message);
                    }
                }
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return Json(new { Result = result, Message = message, LastSynch = lastSynch });
        }

        [HttpPost, Route("LoadEnrollmentAccounts")]
        public JsonResult LoadEnrollmentAccounts(BUILD_01_BUILD_SITE building, string capturedSelection)
        {
            IMP_Enrolled_View[] toReturn = null;
            IEnumerable<IMP_Enrolled_View> query = null;
            string result = "Success";
            string message = string.Empty;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    //toReturn = context.EnrolledAccounts
                    switch (capturedSelection)
                    {
                        case "all":
                            query = context.IMP_Enrolled_View.Where(o => o.BUILDING == building.Building_Name && o.LEASE_NUM != null);
                            break;
                        case "yes":
                            query = context.IMP_Enrolled_View.Where(o => o.BUILDING == building.Building_Name && o.LEASE_NUM != null && o.EMP_EmployeeNo != null);
                            break;
                        case "no":
                            query = context.IMP_Enrolled_View.Where(o => o.BUILDING == building.Building_Name && o.LEASE_NUM != null && o.EMP_EmployeeNo == null);
                            break;
                    }
                    toReturn = query.OrderBy(o => o.BUILDING).ThenBy(o => o.OCC_ACCOUNT_NUMBER).ToArray<IMP_Enrolled_View>();
                }
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return Json(new { Result = result, Message = message, EnrolledAccounts = toReturn });
        }


        [HttpPost, Route("BulkTransfer")]
        public JsonResult BulkTransfer(BUILD_01_BUILD_SITE building)
        {
            string result = string.Empty;
            string message = string.Empty;
            bool showSubForm = false;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    context.BulkStudentsTransferPerBuilding(building);
                    result = "Success";
                    message = "The tenants has been created on Biometrics. You may now enroll their fingerprints.";
                }

            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return Json(new { Result = result, Message = message, ShowSubForm = showSubForm });
        }

        [HttpPost, Route("ShowStudentMultipleLeaseForBuilding")]
        public JsonResult ShowStudentMultipleLeaseForBuilding(BUILD_01_BUILD_SITE building)
        {
            string result = string.Empty;
            string message = string.Empty;
            List<occ_001_occ_stat_data_Fin> toReturn = null;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    toReturn = (from F in context.occ_001_occ_stat_data_Fin
                                join M in context.MASTER_INT_MASS_TRF on F.OCC_ACCOUNT_NUMBER equals M.ACCOUNT_NUMBER
                                where F.LOCATION_CODE == M.LOCATION_CODE
                                && F.BUILDING.ToUpper() == building.Building_Name.ToUpper()
                                select F).ToList();

                    result = "Success";
                    message = "Data retrieved";
                }
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return Json(new { Result = result, Message = message, MultipleLeases = toReturn });
        }

        [HttpPost, Route("StudentMassDelete")]
        public JsonResult StudentMassDelete(string buildingName)
        {
            string result = string.Empty;
            string message = string.Empty;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    context.BulkStudentsDeletePerBuilding(buildingName);
                    result = "Success";
                    message = string.Format("Student successfully marked for deletion for {0}. They will be deleted shortly", buildingName);
                }
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return Json(new { Result = result, Message = message });
        }
        #endregion

        #region [Employee]

           

        [HttpPost, Route("SearchForEmployee")]
        public async Task<IActionResult> SearchForEmployee([FromBody]EmployeeInfoViewModel employeeInfoViewModel)
        {
            string result = "Success";
            string message = string.Empty;
            EmployeeInfo employee = null;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    employee = context.GetEmployeeInformation(employeeInfoViewModel.idnumber);
                }

                message = "No such employee found";
                if (employee != null)
                    message = "Employee found";

            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
                return this.Ok(new { error = message, data = "Internal Server Error" });
            }

            return this.Ok(new { Result = result, Message = message, Employee = employee });
        }

        [HttpPost, Route("UpdateEmployeeInBio")]
        public IActionResult UpdateEmployeeInBio([FromBody]UpdateEmployeeInBioViewModel updateEmployeeInBio)
        {
            string result = "Success";
            string message = string.Empty;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    if (updateEmployeeInBio.create)
                    {
                        context.TransferToBiometric(updateEmployeeInBio.employee, updateEmployeeInBio.user);
                        message = "Employee successfully created";
                    }
                    else
                    {
                        context.UpdateEmployeeEnrollment(updateEmployeeInBio.employee);
                        message = "Employee successfully updated";
                    }
                }
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                //logException(ex);
                return this.Ok(new { error = message, data = "Internal Server Error" });
            }
            return this.Ok(new { Result = result, Message = message, EmployeeInfo = updateEmployeeInBio.employee });
        }

        [HttpPost, Route("DeleteEmployeeFromBio")]
        public JsonResult DeleteEmployeeFromBio([FromBody]EmployeeInfoViewModel employeeInfoViewModel)
        {
            string result = "Success";
            string message = string.Empty;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    context.DeleteBiometricEntry(employeeInfoViewModel.employeeNo, employeeInfoViewModel.user);
                }
                message = "Employee successfully deleted";
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return Json(new { Result = result, Message = message });
        }

        [HttpPost, Route("GetEmployeeRegions")]
        public JsonResult GetEmployeeRegions()
        {
            string result = "Success";
            string message = string.Empty;
            List<IMP_TAGHOLDER_ACCESS_GROUP> regions = null;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    regions = context.GetRegions(BiometricEntryType.Employee);
                }
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
                logException(ex);
            }
            return Json(new { Result = result, Message = message, Regions = regions });
        }

        [HttpPost, Route("GetEmployeeDepartments")]
        public JsonResult GetEmployeeDepartments()
        {
            string result = "Success";
            string message = string.Empty;
            List<DEPARTMENT_ARCH> departments = null;
            dynamic jsonDeparments = null;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    departments = context.GetDepartmentsForEmployees();
                    jsonDeparments = departments.Select(o => new { Name = o.DEPT_Name }).ToList();
                }
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
            }
            return Json(new { Result = result, Message = message, Departments = jsonDeparments });
        }
        #endregion

        #region [Configuration]


        [HttpPost, Route("ImportOracleConfig")]
        public JsonResult ImportOracleConfig()
        {
            string result = string.Empty;
            string message = string.Empty;
            try
            {
                var stopwatch = System.Diagnostics.Stopwatch.StartNew();
                result = "Success";
                using (var context = new StagingDBEntities())
                {
                    context.ImportOracleConfig();
                }
                stopwatch.Stop();
                message = string.Format("The Occupancy data has been updated. Opperation took a total of {0} seconds", stopwatch.Elapsed.TotalSeconds);

            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
            }
            return this.Json(new { Result = result, Message = message });
        }  

        [HttpPost, Route("UpdateRoomTypeConfiguration")]
        public JsonResult UpdateRoomTypeConfiguration(BUILD_01_BUILD_SITE building, int maxOccupants, string roomType)
        {
            string result = string.Empty;
            string message = string.Empty;
            try
            {
                using (var context = new StagingDBEntities())
                {
                    context.UpdateRoomTypeConfiguration(building.Building_Name, roomType, maxOccupants);
                }
                result = "Success";
                message = "Configuration Successfully updated";
            }
            catch (Exception ex)
            {
                result = "Error";
                message = this.getExceptionMessage(ex);
            }
            return this.Json(new { Result = result, Message = message });
        }

        #endregion

        #region [Private methods]
        [HttpPost, Route("updateBiometric")]
        private JsonResult updateBiometric(AccountInformation accountInformation, BuildingType buildingType, bool ignoreRoomConfigError)
        {
            string message = string.Empty;

            bool response = this.BiometricLogic.UpdateBiometric(accountInformation, buildingType, ignoreRoomConfigError, CurrentUser.name, out message);

            return this.Json(new { Result = response ? "Success" : "Error", Message = message });
        }

        [HttpPost, Route("getCustomerLeaseEnrollmentData")]
        private JsonResult getCustomerLeaseEnrollmentData(string idNumber, string accountNumber, string accountName, BuildingType buildingType)
        {
            AccountInformation accountInfo = null;
            LeaseInformation leaseInfo = null;
            string result = "Success";
            string message = string.Empty;
            LeaseEnrollmentComparer comparison = null;
            AccountInformationValidator validator = null;
            ResidentialConfig residentialConfig = null;
            //List<Res_02_Alloc_Tens> subTenants = null;

            try
            {
                using (var context = new StagingDBEntities())
                {
                    accountInfo = this.getAccountInformation(context, idNumber, accountNumber, accountName, out validator, buildingType);
                    if (validator.IsValid)
                    {
                        var enrollmentInfo = context.GetEnrollmentInformation(accountInfo);
                        var leaseNum = string.Empty;
                        var endDate = string.Empty;
                        if (enrollmentInfo != null)
                        {
                            leaseNum = enrollmentInfo.LeaseNumber;
                            endDate = enrollmentInfo.EndDate.ToString();
                        }

                        leaseInfo = context.GetLeaseInformation(accountInfo, buildingType, leaseNum, endDate); //TODO: Residentail lease Info should come directly from Oracle
                                                                                                               // this.BioLogic.GetLeaseEnrollmentInfo(accountInfo, leaseInfo.LeaseID, buildingType.ToString());
                        leaseInfo = accountInfo.LeaseInformation;
                        //we are going to attempt to find what type of customer the customer has as it is not defined yet
                        if (string.IsNullOrEmpty(accountInfo.CustomerClassCode) && (leaseInfo == null || leaseInfo.LeaseID == default(int)))
                        {
                            var tempBuildType = BuildingType.Employee;
                            if (buildingType == BuildingType.Residential)
                                tempBuildType = BuildingType.Student;
                            else if (buildingType == BuildingType.Student)
                                tempBuildType = BuildingType.Residential;

                            if (tempBuildType != BuildingType.Employee)
                            {
                                leaseInfo = context.GetLeaseInformation(accountInfo, tempBuildType);
                                //So now that we have changed the type we need to check if we could find a lease. If so then we know the customer class code
                                if (leaseInfo != null && leaseInfo.LeaseID != default(int))
                                {
                                    accountInfo.CustomerClassCode = tempBuildType.ToString().ToUpper();
                                    //Now we have to clear the lease again because we need to notify the user that he or she is on the wrong screen
                                    leaseInfo = null;
                                }
                            }
                        }

                        if (leaseInfo == null || leaseInfo.LeaseID == default(int))
                        {
                            if (accountInfo.CustomerClassCode == "STUDENT" && buildingType == BuildingType.Residential)
                            {
                                result = "Error";
                                message = "The customer you are searching for is a student customer. Please use the student enrollment form.";
                            }
                            else if (accountInfo.CustomerClassCode == "RESIDENTIAL" && buildingType == BuildingType.Student)
                            {
                                result = "Error";
                                message = "The customer you are searching for is a residential customer. Please use the residential enrollment form.";
                            }

                        }
                        else
                        {
                            accountInfo.HasEnrollmentArchive = context.HasHistotyRecord(accountInfo.Identifier);

                            if (buildingType == BuildingType.Residential)
                            {
                                residentialConfig = context.GetResidentialConfig(leaseInfo.LocationCode);
                                //subTenants = context.LoadResidentialSubTenants(accountInfo, enrollmentInfo);
                                context.GetLeaseParkingDetails(leaseInfo);
                            }
                        }
                        //determine if their are any other enrollments for the room
                        //List<Res_02_Alloc_Tens> enrollments = EnrollmentInformation.getExistingEnrollment(accountInfo.AccountNumber, accountInfo.LeaseInformation.LocationCode);
                        //if (enrollments.Count > 0)
                        //{
                        //    result = "Error";
                        //    message = "There are one or more existing enrollments in the location specified in the tenant lease. Please investigate the following enrollment(s) before continuing: " + System.Environment.NewLine;
                        //    int enrollmentCount = 1;
                        //    foreach (Res_02_Alloc_Tens entry in enrollments)
                        //    {
                        //        message += System.Environment.NewLine;
                        //        message += entry.MST_FirstName + " " + entry.MST_LastName + " (Account Number " + entry.ACCOUNT_NUMBER + ")"; 
                        //        if (enrollmentCount < enrollments.Count)
                        //        {
                        //            message += ", ";
                        //        }
                        //        else 
                        //        {
                        //            message += ".";
                        //        }
                        //    }
                        //    enrollmentCount++; 
                        //}

                        //we stil need to run the comparison even if there are no lease
                        //the comparison will generate the error mesages
                        comparison = new LeaseEnrollmentComparer(enrollmentInfo, leaseInfo, validator.isOrganization);
                    }
                    else
                    {
                        result = "Error";
                        message = validator.Message;
                    }
                }
                return Json(new { Result = result, Message = message, AccountInformation = accountInfo, AccountValidator = validator, Comparison = comparison, ResidentialConfig = residentialConfig });//, SubTenants = subTenants });
            }
            catch (Exception ex)
            {
                message = this.getExceptionMessage(ex);
                logException(ex);
                return Json(new { Result = "Error", Message = message });
            }
        }

        private AccountInformation getAccountInformation(StagingDBEntities context, string IdNumber, string accountNumber, string accountName, out AccountInformationValidator validator, BuildingType buildingType)
        {
            AccountInformation toReturn = null;
            toReturn = this.BiometricLogic.GetAccountInformation(context, IdNumber, accountNumber, accountName, out validator, buildingType);
            return toReturn;
        }

        private string getExceptionMessage(Exception ex)
        {
            string toReturn = string.Empty;
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            toReturn = ex.Message;
            if (string.IsNullOrEmpty(toReturn))
                toReturn = ex.ToString();

            return toReturn;
        }

        private void logException(Exception ex)
        {
            ILog logger = LogManager.GetLogger(typeof(BiometricController));
            string toLog = string.Empty;
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            toLog = ex.Message;
            if (string.IsNullOrEmpty(toLog))
                toLog = ex.ToString();

            logger.Error(toLog);
        }

        #endregion

        #region [Excel Exports]
        [HttpPost, Route("ExportProfileComparisonToExcel")]
        public JsonResult ExportProfileComparisonToExcel()
        {
            string result = "Success";
            string message = string.Empty;
            string downloadPath = string.Empty;

            try
            {
                string ExcelFileName = "Biometric_Profile_Comparison";
                string fileName = string.Concat(ExcelFileName, DateTime.Now.ToString("yyyyMMddmmss"), ".xls");

                string webRootPath = _hostingEnvironment.WebRootPath;
                string file = Path.Combine(webRootPath, "Excel", fileName);
                //string file = string.Concat(Server.MapPath("~/Excel"), "/", fileName);
                //downloadPath = string.Concat("../Excel/", fileName);

                using (var context = new StagingDBEntities())
                {
                    context.ExportProfileComparisonToExcel(file);
                }
            }
            catch (Exception ex)
            {
                message = this.getExceptionMessage(ex);
                logException(ex);
                result = "Error";

            }
            return Json(new { Result = result, Message = message, DownloadPath = downloadPath });
        }

        [HttpPost, Route("ExportMissingBiometricsToExcel")]
        public JsonResult ExportMissingBiometricsToExcel()
        {
            string result = "Success";
            string message = string.Empty;
            string downloadPath = string.Empty;

            try
            {
                string ExcelFileName = "Biometric_Missing_Biometrics";
                string fileName = string.Concat(ExcelFileName, DateTime.Now.ToString("yyyyMMddmmss"), ".xls");

                string webRootPath = _hostingEnvironment.WebRootPath;
                string file = Path.Combine(webRootPath, "Excel", fileName);

                //string file = string.Concat(Server.MapPath("~/Excel"), "/", fileName);
                //downloadPath = string.Concat("../Excel/", fileName);

                using (var context = new StagingDBEntities())
                {
                    context.ExportMissingBiometricsToExcel(file);
                }

            }
            catch (Exception ex)
            {
                message = this.getExceptionMessage(ex);
                logException(ex);
                result = "Error";

            }
            return Json(new { Result = result, Message = message, DownloadPath = downloadPath });
        }

        [HttpPost, Route("ExportMissingFingerprintsToExcel")]
        public JsonResult ExportMissingFingerprintsToExcel()
        {
            string result = "Success";
            string message = string.Empty;
            string downloadPath = string.Empty;

            try
            {
                string ExcelFileName = "Biometric_Missing_Fingerprints";
                string fileName = string.Concat(ExcelFileName, DateTime.Now.ToString("yyyyMMddmmss"), ".xls");

                string webRootPath = _hostingEnvironment.WebRootPath;
                string file = Path.Combine(webRootPath, "Excel", fileName);

                //string file = string.Concat(Server.MapPath("~/Excel"), "/", fileName);
                //downloadPath = string.Concat("../Excel/", fileName);

                using (var context = new StagingDBEntities())
                {
                    context.ExportMissingFingerprintsToExcel(file);
                }

            }
            catch (Exception ex)
            {
                message = this.getExceptionMessage(ex);
                logException(ex);
                result = "Error";

            }
            return Json(new { Result = result, Message = message, DownloadPath = downloadPath });
        }

        [HttpPost, Route("ExportMissingLeaseToExcel")]
        public JsonResult ExportMissingLeaseToExcel()
        {
            string result = "Success";
            string message = string.Empty;
            string downloadPath = string.Empty;

            try
            {
                string ExcelFileName = "Biometric_Missing_Lease";
                string fileName = string.Concat(ExcelFileName, DateTime.Now.ToString("yyyyMMddmmss"), ".xls");

                string webRootPath = _hostingEnvironment.WebRootPath;
                string file = Path.Combine(webRootPath, "Excel", fileName);

                //string file = string.Concat(Server.MapPath("~/Excel"), "/", fileName);
                //downloadPath = string.Concat("../Excel/", fileName);

                using (var context = new StagingDBEntities())
                {
                    context.ExportMissingLeaseToExcel(file);
                }

            }
            catch (Exception ex)
            {
                message = this.getExceptionMessage(ex);
                logException(ex);
                result = "Error";

            }
            return Json(new { Result = result, Message = message, DownloadPath = downloadPath });
        }

        [HttpPost, Route("ExportTenantActivityToExcel")]
        public JsonResult ExportTenantActivityToExcel()
        {
            string result = "Success";
            string message = string.Empty;
            string downloadPath = string.Empty;

            try
            {
                string ExcelFileName = "Biometric_Tenant_Activity";
                string fileName = string.Concat(ExcelFileName, DateTime.Now.ToString("yyyyMMddmmss"), ".xls");

                string webRootPath = _hostingEnvironment.WebRootPath;
                string file = Path.Combine(webRootPath, "Excel", fileName);

                //string file = string.Concat(Server.MapPath("~/Excel"), "/", fileName);
                //downloadPath = string.Concat("../Excel/", fileName);

                using (var context = new StagingDBEntities())
                {
                    context.ExportTenantActivityToExcel(file);
                }

            }
            catch (Exception ex)
            {
                message = this.getExceptionMessage(ex);
                logException(ex);
                result = "Error";

            }
            return Json(new { Result = result, Message = message, DownloadPath = downloadPath });
        }

        [HttpPost, Route("ExportTenantInactivityToExcel")]
        public JsonResult ExportTenantInactivityToExcel()
        {
            string result = "Success";
            string message = string.Empty;
            string downloadPath = string.Empty;

            try
            {
                string ExcelFileName = "Biometric_Tenant_Inactivity";
                string fileName = string.Concat(ExcelFileName, DateTime.Now.ToString("yyyyMMddmmss"), ".xls");

                string webRootPath = _hostingEnvironment.WebRootPath;
                string file = Path.Combine(webRootPath, "Excel", fileName);

                //string file = string.Concat(Server.MapPath("~/Excel"), "/", fileName);
                //downloadPath = string.Concat("../Excel/", fileName);

                using (var context = new StagingDBEntities())
                {
                    context.ExportTenantInactivityToExcel(file);
                }

            }
            catch (Exception ex)
            {
                message = this.getExceptionMessage(ex);
                result = "Error";

            }
            return Json(new { Result = result, Message = message, DownloadPath = downloadPath });
        }

        [HttpPost, Route("ExportTenantActivityBetweenDatesToExcel")]
        public JsonResult ExportTenantActivityBetweenDatesToExcel()
        {
            string result = "Success";
            string message = string.Empty;
            string downloadPath = string.Empty;

            try
            {
                string ExcelFileName = "Biometric_Tenant_Activity_Between_Dates";
                string fileName = string.Concat(ExcelFileName, DateTime.Now.ToString("yyyyMMddmmss"), ".xls");

                string webRootPath = _hostingEnvironment.WebRootPath;
                string file = Path.Combine(webRootPath, "Excel", fileName);

                //string file = string.Concat(Server.MapPath("~/Excel"), "/", fileName);
                //downloadPath = string.Concat("../Excel/", fileName);

                using (var context = new StagingDBEntities())
                {
                    context.ExportTenantActivityBetweenDatesToExcel(file);
                }

            }
            catch (Exception ex)
            {
                message = this.getExceptionMessage(ex);
                logException(ex);
                result = "Error";

            }
            return Json(new { Result = result, Message = message, DownloadPath = downloadPath });
        }
        #endregion

        [HttpGet, Route("test")]
        public JsonResult Test()
        {
            try
            {
                using (var context = new StagingDBEntities())
                {
                    var lastSynch = context.Mass_Upd_Time.Where(o => o.Action_Desc == "Occ_Upd").FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                return Json(new { Error = ex.ToString() });
            }
            return Json(new { Result = "Success" });
        }
    }
}