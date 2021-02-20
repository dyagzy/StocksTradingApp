using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck.Entity
{
    public class CompanyProfile
    {
        public string CompanyName { get; set; }
        public string MarketClassification { get; set; }
        public string Sector { get; set; }
        public string NatureOfBusiness { get; set; }
        public string CompanyAddress { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Auditor { get; set; }
        public string Regristra { get; set; }
        public string CompanySecretay { get; set; }
        public DateTime DateListed { get; set; }
        public DateTime DateOfIncorporation { get; set; }
        public string Website { get; set; }
        public string BoardOfDirectors { get; set; }
        public DateTime OfficialOpen { get; set; }
        public DateTime OfficalClose { get; set; }
    }
}
