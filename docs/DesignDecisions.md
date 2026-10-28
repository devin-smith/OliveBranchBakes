
# Olive Branch Bakes - Design Decision Record

## Phase 3A - Core Ordering System

### Decision 1 - Using Decimal for Currency

**Date:** October 27, 2026

**Files:** Models/MenuItem.cs, Models/OrderItem.cs, Models/Order.cs

**Methods:** MenuItem(), OrderItem(), OrderItem.LineTotal

**Decision:**
I chose to use decimal for all monetary values in the application. Since the bakery processes orders and calculates totals, decimal is better suited for currency because it avoids the floating-point precision issues that can occur with double. This will help maintain accurate pricing when discounts and taxes are calculated.

**Alternative:**
Using double was considered but rejected because floating-point calculations can produce rounding errors with money.

**Testing:**
T1, T2, T3, T4, T5 - Expected calculations were completed before implementing the PricingService. Actual results are pending.

**Source/AI Use:**
Phase 3 assignment requirements and AI assistance with C# model implementation.

**Commit:**
https://github.com/devin-smith/OliveBranchBakes/commit/5188fbe74035fd7a08120c58bc1eed2ecba0844a

---

### Decision 2 - JSON Data Storage

**Date:** October 27, 2026

**Files:** Services/DataStore.cs, Services/SeedData.cs, Models/BakeryData.cs

**Methods:** DataStore.Save(), DataStore.Load(), SeedData.Create()

**Decision:**
I selected JSON for storing the bakery's menu items, customers, orders, and application settings. JSON is easy to read and allows the application to save information locally without requiring a separate database. It also works with the existing class structure and can be expanded as the project develops.

**Alternative:**
SQLite was considered but not selected because JSON is simpler for this stage of the project and meets the assignment's persistence requirements.

**Testing:**
Created 16 menu items, 3 customers, and 8 sample orders. Saved the information to bakerydata.json, closed the application, and reopened it. The application successfully loaded the existing data without replacing the saved records.

**Source/AI Use:**
Phase 3 assignment requirements and AI assistance with System.Text.Json serialization and deserialization.

**Commit:**
https://github.com/devin-smith/OliveBranchBakes/commit/3ebf71755ccfd982dea02f9c9ffc3042d78b61de

---

### Decision 3 - Separating Models and Services

**Date:** October 27, 2026

**Files:** Models/BakeryData.cs, Models/Customer.cs, Models/Order.cs, Services/DataStore.cs

**Methods:** DataStore.Save(), DataStore.Load()

**Decision:**
I decided to keep the application's data models separate from the services that perform operations. The models store information about products, customers, and orders, while services handle tasks such as saving and loading data. This keeps the project organized and makes it easier to maintain and add functionality in future phases.

**Alternative:**
Placing data storage and business logic directly inside Windows Forms was considered but rejected because it would make the application harder to maintain, troubleshoot, and test.

**Testing:**
The application builds successfully, and the DataStore service saves and reloads model data after restarting. Additional tests for pricing, quantity limits, and scheduling will be completed in later phases.

**Source/AI Use:**
Phase 2 architecture, Phase 3 assignment requirements, and AI assistance with organizing the application classes.

**Commit:**
https://github.com/devin-smith/OliveBranchBakes/commit/d5d65a00f8dd7bdcbd3f8d017d6d0ed93324cb64

---

## Phase 3A Summary

Three design decisions were documented for this checkpoint.

1. Decimal is used for monetary values.
2. JSON is used for persistent application data.
3. Models and services are separated to maintain the application's object-oriented structure.

The application currently saves and reloads seed data successfully. Pricing, account authentication, and order validation will be implemented and tested in later phases.

Additional design decisions will be documented during Phase 3B, Phase 3C, and Phase 3D.
