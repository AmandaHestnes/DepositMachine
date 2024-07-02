# Can And Bottle Deposit Machine

This project is a simulation of a can/bottle deposit machine, similar to those found in many Norwegian grocery stores. The machine accepts empty bottles and cans for recycling and issues a voucher for the returned value, which can be used in the store.

## Featues
- Accepts empty bottles and cans.
- Issues a voucher as a reward for returning bottles and cans.
- Logs each transaction.
- Provides a simple console-based UI for interaction.

## Assumptions
- All turned-in bottles are empty.
- When printing a voucher, the voucher amount and count are reset, but the total amount and count remain unchanged.
- Showing the log does not reset any values.

## Technology 
- **Framework:** .NET 8
- **Testing Framework:** NUnit
