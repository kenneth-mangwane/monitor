using OBS.Core.Biometric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.API.Models.ViewModel.Biometric
{
    public class UpdateResidentialMainTenantViewModel
    {
        public string user { get; set; }
        public AccountInformation accountInfo { get; set; }
        public bool ignoreRommConfigError { get; set; }
    }
}
