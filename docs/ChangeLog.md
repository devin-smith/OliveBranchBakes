
# Olive Branch Bakes - Change Log

## Phase 3A - October 27, 2026

| File / Component | Change | Reason |
|---|---|---|
| Models/MenuItem.cs | Added product properties, pricing, allergens, and seasonal availability. | Support bakery products and seasonal items. |
| Models/Category.cs | Added product category model. | Organize bakery products for browsing. |
| Models/PickupTime.cs | Added pickup date and time model. | Support future pickup scheduling. |
| Models/Customer.cs | Added password hash, salt, and loyalty-related properties. | Prepare for customer authentication and loyalty discounts. |
| Models/Order.cs | Added order statuses, confirmation numbers, line items, and totals. | Support the ordering process. |
| Models/OrderItem.cs | Added product name, unit price, quantity validation, and line total. | Preserve prices and calculate order lines. |
| Models/BakeryData.cs | Added data container for application records. | Group information for JSON storage. |
| Models/BakerySettings.cs | Added configurable tax, quantity, loyalty, and pickup settings. | Avoid hard-coding business rules in forms. |
| Services/DataStore.cs | Added JSON saving and loading. | Preserve application data after restarting. |
| Services/SeedData.cs | Added 16 products, 3 customers, and 8 sample orders. | Provide required test data. |
| Program.cs | Added initial seed creation and existing-data loading. | Initialize data when the application starts. |
| docs/VariantCard.md | Documented assigned seasonal, operations, and pricing rules. | Meet student-specific assignment requirements. |
| docs/TestTable.md | Added 12 expected tests and calculations. | Document expected results before pricing implementation. |
| docs/DesignDecisions.md | Documented three architecture decisions. | Explain development choices and alternatives. |
| docs/DeveloperJournal.md | Recorded development work, troubleshooting, and AI assistance. | Maintain development history. |

## Phase 3A Testing

- Solution builds successfully.
- Initial seed data was created.
- JSON data saved to the local AppData folder.
- Application restarted and loaded existing data.
- Verified 16 menu items, 3 customers, and 8 orders.
- Expected calculations documented before pricing implementation.

## Remaining Development

- Phase 3B: Menu browsing, seasonal filtering,
  shopping cart, and running subtotal.
- Phase 3C: Pricing, scheduling, authentication,
  order placement, and confirmations.
- Phase 3D: Final testing, documentation,
  and customer ordering workflow.
