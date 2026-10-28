
# Olive Branch Bakes - Phase 3A Test Table

## Assigned Variant Rules

- Seasonal Item 6: Peppermint brownie, $3.50
- Operations O5: Guest limit 6, signed-in limit 24
- Pricing P2: 10% discount for signed-in customers
  with at least 3 previous orders
- Sales Tax: 8.5%

## Test Cases

| ID | Purpose | Expected Result |
|---|---|---|
| T1 | Baseline guest order | $54.79 |
| T2 | Signed-in, 2 previous orders | No discount |
| T3 | Signed-in, 3 previous orders | 10% discount |
| T4 | Signed-in, 4 previous orders | 10% discount |
| T5 | Same cart, guest versus signed-in | Only eligible signed-in customer receives discount |
| T6 | Guest orders 6 of one item | Accepted |
| T7 | Guest orders 7 of one item | Blocked |
| T8 | Peppermint brownie on November 30 | Unavailable |
| T9 | Quantity of zero | Blocked |
| T10 | Pickup on December 25 | Blocked |
| T11 | Signed-in customer orders 24 of one item | Accepted |
| T12 | Signed-in customer orders 25 of one item | Blocked |

## Test Status

All expected results are calculated before
implementing PricingService.


## Phase 3A - Expected Test Calculations

### T1 - Guest Order
2 × 7.50 = 15.00
6 × 2.25 = 13.50
1 × 22.00 = 22.00
Subtotal = 50.50
50.50 × .085 = 4.2925
Total = $54.79

### T2 - Below Loyalty Threshold (2 Orders)
Subtotal = 50.50
Discount = 0.00
50.50 × .085 = 4.2925
Total = $54.79

### T3 - Loyalty Threshold (3 Orders)
50.50 × .10 = 5.05
50.50 - 5.05 = 45.45
45.45 × .085 = 3.86325
Total = $49.31

### T4 - Above Loyalty Threshold (8 Orders)
50.50 × .10 = 5.05
50.50 - 5.05 = 45.45
45.45 × .085 = 3.86325
Total = $49.31

### T5 - Guest vs. Signed-In Customer
Guest: 50.50 × 1.085 = 54.7925
Guest Total = $54.79

Signed-in (3 previous orders):
50.50 × .10 = 5.05
45.45 × 1.085 = 49.31325
Signed-in Total = $49.31

### T6 - Guest Maximum Quantity
6 × 2.25 = 13.50
13.50 × .085 = 1.1475
Total = $14.65
6 <= 6 = ACCEPTED

### T7 - Guest Exceeds Quantity Limit
7 > 6 = BLOCKED
Expected: Quantity limit exceeded

### T8 - Seasonal Item Outside Availability
Pickup = November 30
Season Start = December 1
November 30 < December 1 = BLOCKED

### T9 - Invalid Quantity
Quantity = 0
0 < 1 = BLOCKED

### T10 - Restricted Pickup Date
Pickup = December 25
December 25 = Restricted Date
Result = BLOCKED

### T11 - Signed-In Maximum Quantity
24 × 2.25 = 54.00
54.00 × .085 = 4.59
Total = $58.59
24 <= 24 = ACCEPTED
Previous Orders = 0 (No discount)

### T12 - Signed-In Exceeds Quantity Limit
25 > 24 = BLOCKED
Expected: Quantity limit exceeded

## Test Status

Expected Results: Calculated before pricing code
Actual Results: Pending implementation
Pass/Fail: Pending testing

