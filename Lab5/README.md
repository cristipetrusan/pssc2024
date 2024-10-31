Here’s a set of sample entries for each table (`Product`, `OrderHeader`, `OrderLine`) to help illustrate how the data would look and how these entries are related:

### 1. **Product Table**
- Stores details about products available for order.

| ProductId | Code     | Stoc |
|-----------|----------|------|
| 1         | PROD001  | 100  |
| 2         | PROD002  | 50   |
| 3         | PROD003  | 200  |

**Explanation**:
- `ProductId`: Unique identifier for each product.
- `Code`: Unique code to identify the product externally (could be SKU, for example).
- `Stoc`: Quantity of the product in stock.

For example:
- Product with `ProductId = 1` has the code "PROD001" and 100 units in stock.

### 2. **OrderHeader Table**
- Holds details about an entire order, including customer address and total amount.

| OrderId | Address                | Total   |
|---------|-------------------------|---------|
| 1       | 123 Main St, City A     | 300.00  |
| 2       | 456 Elm St, City B      | 450.00  |

**Explanation**:
- `OrderId`: Unique identifier for each order.
- `Address`: Address where the order is to be delivered.
- `Total`: Total cost for the entire order.

For example:
- Order with `OrderId = 1` is to be delivered to "123 Main St, City A" with a total cost of 300.00.

### 3. **OrderLine Table**
- Contains items in each order, including the product ordered, quantity, and price for each line item.

| OrderLineId | OrderId | ProductId | Quantity | Price |
|-------------|---------|-----------|----------|-------|
| 1           | 1       | 1         | 2        | 100.00 |
| 2           | 1       | 2         | 1        | 200.00 |
| 3           | 2       | 1         | 3        | 100.00 |
| 4           | 2       | 3         | 1        | 150.00 |

**Explanation**:
- `OrderLineId`: Unique identifier for each line item within an order.
- `OrderId`: References the `OrderHeader` to indicate which order this line item belongs to.
- `ProductId`: References the `Product` table to indicate which product is being ordered.
- `Quantity`: Number of units ordered of this product.
- `Price`: Price per unit for this line item.

For example:
- `OrderLineId = 1` belongs to `OrderId = 1`, which includes `ProductId = 1` (code "PROD001") with a quantity of 2 units at a price of 100.00 per unit.

### Putting it all together
In these tables:
- Order with `OrderId = 1` has a total of 300.00 and contains two items (`OrderLineId = 1` and `OrderLineId = 2`).
- The products in `OrderId = 1` include 2 units of "PROD001" at 100.00 each and 1 unit of "PROD002" at 200.00, matching the total of 300.00.

This design enables tracking of individual products, the overall order, and the details of each item in an order.