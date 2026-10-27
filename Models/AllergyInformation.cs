using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Models
{
    internal class AllergyInformation
    {
        public int AllergyInformationId { get; set; }
        public int OrderId { get; set; }
        public string Notes { get; set; } = "";
    }
}
