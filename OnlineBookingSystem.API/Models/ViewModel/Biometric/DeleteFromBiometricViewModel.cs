using OBS.Core.Biometric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.API.Models.ViewModel.Biometric
{
    public class DeleteFromBiometricViewModel
    {
        public AccountInformation accountInformation { get; set; }
        public string user { get; set; }
    }
}
