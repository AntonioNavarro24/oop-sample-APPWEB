# User Stories

this document contains user stories for the main features of the application.

## US001: Create a Purchase Order
**As a** Procurement Manager,
**I want to** create a purchase order for a supplier,
**So that** I can manage the procurement process efficiently.

### Acceptance Criteria
### Scenario 1 : Create a Purchase Order with Valid Supplier
**Given** A supplier with code "SUP123", name "ABC Supplies", and address "123 Main St",
**When** The procurement manager creates a purchase order with the supplier,
**Then** The purchase order should be created successfully with the supplier's details.

## Scenario 2 : Create a Purchase Order with Invalid Supplier
**Given** A supplier with code "SUP123", name "ABC Supplies", and address "123 Main St",
**When** The procurement manager creates a purchase order with an invalid supplier code "INVALID",
**Then** An error message should be displayed indicating that the supplier is invalid.