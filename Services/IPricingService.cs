using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public interface IPricingService
    {
        decimal GetTotal(
            List<CartItem> items,
            bool isSignedIn,
            int previousOrders);
    }
}
