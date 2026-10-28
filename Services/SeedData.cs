using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public static class SeedData
    {
        public static BakeryData Create()
        {
            BakeryData data = new BakeryData();

            // Bakery product categories.
            data.Categories.Add(new Category(
                1, "Breads", "Freshly baked breads"));

            data.Categories.Add(new Category(
                2, "Cookies", "Homemade cookies"));

            data.Categories.Add(new Category(
                3, "Muffins", "Fresh breakfast muffins"));

            data.Categories.Add(new Category(
                4, "Pastries", "Pastries and rolls"));

            data.Categories.Add(new Category(
                5, "Pies", "Traditional bakery pies"));

            data.Categories.Add(new Category(
                6, "Cakes", "Cakes for special occasions"));

            data.Categories.Add(new Category(
                7, "Extras", "Additional bakery products"));

            data.Categories.Add(new Category(
                8, "Seasonal Treats", "Limited seasonal items"));

            // Regular bakery menu items.
            data.MenuItems.Add(new MenuItem(
                1, "Sourdough loaf",
                "Traditional sourdough bread",
                7.50m, "Breads"));

            data.MenuItems.Add(new MenuItem(
                2, "Chocolate chip cookie",
                "Classic chocolate chip cookie",
                2.25m, "Cookies"));

            data.MenuItems.Add(new MenuItem(
                3, "Blueberry muffin",
                "Fresh blueberry muffin",
                3.00m, "Muffins"));

            data.MenuItems.Add(new MenuItem(
                4, "Cinnamon roll",
                "Cinnamon pastry with icing",
                3.75m, "Pastries"));

            data.MenuItems.Add(new MenuItem(
                5, "Apple pie 9 inch",
                "Traditional apple pie",
                22.00m, "Pies"));

            data.MenuItems.Add(new MenuItem(
                6, "Custom decorated cake",
                "Decorated cake for special occasions",
                45.00m, "Cakes"));

            data.MenuItems.Add(new MenuItem(
                7, "Honey butter jar",
                "Homemade honey butter",
                5.00m, "Extras"));

            data.MenuItems.Add(new MenuItem(
                8, "Banana nut bread",
                "Sweet bread with walnuts",
                8.00m, "Breads"));

            data.MenuItems.Add(new MenuItem(
                9, "Oatmeal raisin cookie",
                "Soft oatmeal raisin cookie",
                2.00m, "Cookies"));

            data.MenuItems.Add(new MenuItem(
                10, "Lemon poppy seed muffin",
                "Lemon muffin with poppy seeds",
                3.25m, "Muffins"));

            data.MenuItems.Add(new MenuItem(
                11, "Chocolate croissant",
                "Flaky pastry with chocolate",
                4.00m, "Pastries"));

            data.MenuItems.Add(new MenuItem(
                12, "Pecan pie 9 inch",
                "Southern-style pecan pie",
                24.00m, "Pies"));

            data.MenuItems.Add(new MenuItem(
                13, "Vanilla pound cake",
                "Traditional vanilla pound cake",
                18.00m, "Cakes"));

            data.MenuItems.Add(new MenuItem(
                14, "Dinner rolls 6 pack",
                "Freshly baked dinner rolls",
                6.00m, "Breads"));

            data.MenuItems.Add(new MenuItem(
                15, "Sugar cookie",
                "Classic homemade sugar cookie",
                2.00m, "Cookies"));

            // Seasonal item: Variant 6.
            // Third-to-last digit of student ID.
            // Available December 1 through December 31.
            MenuItem seasonalItem = new MenuItem(
                16, "Peppermint brownie",
                "Chocolate brownie with peppermint",
                3.50m, "Seasonal Treats");

            seasonalItem.SeasonStart =
                new DateTime(2026, 12, 1);

            seasonalItem.SeasonEnd =
                new DateTime(2026, 12, 31);

            data.MenuItems.Add(seasonalItem);


            // Sample customers for account and loyalty testing.
            // Password hashes will be assigned by AccountService
            // when authentication is implemented in Phase 3C.

            data.Customers.Add(new Customer(
                1, "Sarah Johnson",
                "sarah@example.com",
                "555-0101"));

            data.Customers.Add(new Customer(
                2, "Michael Davis",
                "michael@example.com",
                "555-0102"));

            data.Customers.Add(new Customer(
                3, "Emily Wilson",
                "emily@example.com",
                "555-0103"));


            // Sample historical orders used to test persistence
            // and future loyalty calculations.
            //
            // Customer 1: 3 previous orders
            // Customer 2: 2 previous orders
            // Customer 3: 1 previous order
            // Guest: 2 orders

            DateTime orderDate = new DateTime(2026, 10, 1, 9, 0, 0);

            DateTime pickup1 = new DateTime(2026, 10, 5, 10, 0, 0);
            DateTime pickup2 = new DateTime(2026, 10, 10, 11, 0, 0);
            DateTime pickup3 = new DateTime(2026, 10, 15, 14, 0, 0);
            DateTime pickup4 = new DateTime(2026, 10, 20, 10, 30, 0);

            for (int i = 1; i <= 8; i++)
            {
                int? customerId = i switch
                {
                    <= 3 => 1,
                    <= 5 => 2,
                    6 => 3,
                    _ => null
                };

                DateTime pickupDate = i switch
                {
                    <= 2 => pickup1,
                    <= 4 => pickup2,
                    <= 6 => pickup3,
                    _ => pickup4
                };

                Order order = new Order(
                    i, customerId, pickupDate);

                order.OrderDate = orderDate;

                order.ConfirmationNumber =
                    $"OBB-261001-{i:000}";

                // Sample orders start in the Received status.
                order.Status = OrderStatus.Received;

                // Copy the product's name and price into the
                // order line to preserve historical pricing.
                order.Items.Add(new OrderItem(
                    i, i, 1,
                    "Sourdough loaf", 7.50m, 2));

                data.Orders.Add(order);
            }



            return data;
        }
    }
}
