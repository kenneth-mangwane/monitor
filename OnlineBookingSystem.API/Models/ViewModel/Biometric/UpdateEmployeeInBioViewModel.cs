using OBS.Core.Biometric.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.API.Models.ViewModel.Biometric
{
    public class UpdateEmployeeInBioViewModel
    {
        public string user { get; set; }
        public bool create { get; set; }
        public EmployeeInfo employee { get; set; }
    }
}
