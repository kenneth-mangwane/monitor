using OBS.Core.Biometric.Models;
using OBS.Core.Biometric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.API.Models.ViewModel.Biometric
{
    public class UpdateStudentBiometricViewModel
    {
        public string user { get; set; }
        public AccountInformation accountInformation { get; set; }
    }
}
