using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Models
{
    public class RegularProduct : Product
    {
        public override bool IsAvailable(DateTime date)
        {
            return true;
        }
    }
}