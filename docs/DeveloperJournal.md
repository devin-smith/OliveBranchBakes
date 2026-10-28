
# Olive Branch Bakes - Developer Journal

## October 27, 2026 - Phase 3A Development

Today I continued developing the Olive Branch Bakes
application by expanding the models created in Phase 2.
I added the missing classes and properties needed for
products, customers, orders, and pickup information.

I implemented JSON storage using DataStore and created
seed data containing 16 menu items, 3 customers, and
8 sample orders. I verified that the application could
save the data, close, and reload the same information
when restarted.

I encountered an accessibility error with OrderItem
because the class was internal while Order was public.
I resolved this by changing OrderItem to a public class.

I also had to locate the JSON file in the Windows
AppData folder and connect the seed data initialization
to Program.cs.

I used AI assistance to understand the model structure,
JSON serialization, and error resolution. I reviewed
the changes and successfully built and tested the
application.

### Related Commits

- Phase 3A model classes:
  https://github.com/devin-smith/OliveBranchBakes/commit/5188fbe74035fd7a08120c58bc1eed2ecba0844a

- Seed data:
  https://github.com/devin-smith/OliveBranchBakes/commit/c08a63e42daf47f2e26623479369b51d32e731d9

- JSON persistence:
  https://github.com/devin-smith/OliveBranchBakes/commit/3ebf71755ccfd982dea02f9c9ffc3042d78b61de
