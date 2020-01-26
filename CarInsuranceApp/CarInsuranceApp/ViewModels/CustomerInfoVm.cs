using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceApp.ViewModels
{
    public class CustomerInfoVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateofBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public bool DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public int InsuranceType { get; set; }

    }
}