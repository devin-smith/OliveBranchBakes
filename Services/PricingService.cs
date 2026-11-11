using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class PricingService : IPricingService
    {
        private const decimal TaxRate = 0.085m;
        private const decimal LoyaltyDiscount = 0.10m;


        public decimal GetSubtotal(List<CartItem> items)
        {
            return items.Sum(item => item.Total);
        }

        public decimal GetDiscount(
            decimal subtotal,
            bool isSignedIn,
            int previousOrders)
        {
            if (isSignedIn && previousOrders >= 3)
            {
                return Math.Round(
                    subtotal * LoyaltyDiscount, 2);
            }

            return 0m;
        }

        public decimal GetTax(decimal subtotalAfterDiscount)
        {
            return Math.Round(
                subtotalAfterDiscount * TaxRate, 2,
                MidpointRounding.AwayFromZero);
        }

        public decimal GetTotal(
            List<CartItem> items,
            bool isSignedIn,
            int previousOrders)
        {
            decimal subtotal = GetSubtotal(items);

            decimal discount = GetDiscount(
                subtotal, isSignedIn, previousOrders);

            decimal taxableAmount = subtotal - discount;

            decimal tax = GetTax(taxableAmount);

            return taxableAmount + tax;
        }
    }
}
