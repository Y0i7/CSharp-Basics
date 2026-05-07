using System.Globalization;

Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

const string showingTotalFormat = "Total: {0:C2}";

const decimal discountMinimumAmount = 30.00m;

var items = new decimal[] { 15.97m, 3.50m, 12.25m, 22.99m, 10.98m };
var discounts = new decimal[] { 0.30m, 0.00m, 0.10m, 0.20m, 0.50m };

var totalAmount = 0m;



for (var currentItemIndex = 0; currentItemIndex < items.Length; currentItemIndex++)
{
    totalAmount += GetDiscountedPrice(items, discounts, currentItemIndex);
}

totalAmount -= TotalMeetsMinimum(totalAmount, discountMinimumAmount) ? 5.00m : 0.00m;

Console.WriteLine(
    showingTotalFormat,
    totalAmount
);

decimal GetDiscountedPrice(decimal[] items, decimal[] discounts, int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum(decimal total, decimal discountMinimumAmount)
{
    return total >= discountMinimumAmount;
}