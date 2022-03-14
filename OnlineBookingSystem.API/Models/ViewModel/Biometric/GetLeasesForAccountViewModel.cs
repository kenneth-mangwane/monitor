using OBS.Core.Biometric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.API.Models.ViewModel.Biometric
{
    public class GetLeasesForAccountViewModel
    {
        public AccountInformation accountInformation { get; set; }
        public bool isStudent { get; set; }
    }
}
