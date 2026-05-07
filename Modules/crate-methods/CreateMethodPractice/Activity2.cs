
using System.Globalization;

Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

const string CurrencyToVNDFormat = "{0:C2} VND = {1:C2} USD";
const string CurrencyToUSDFormat = "{0:C2} USD = {1:C2} VND";

const int CurrentRate = 23500;
double usdAmount = 23.73;

var vndAmount = UsdToVnd(usdAmount, CurrentRate);

Console.WriteLine(
    CurrencyToVNDFormat,
    usdAmount,
    vndAmount
);

usdAmount = VndToUsd(vndAmount, CurrentRate);

Console.WriteLine(
    CurrencyToUSDFormat,
    vndAmount,
    usdAmount
    
);

static int UsdToVnd(double usdAmount, int currentRate)
{
    
    return (int)(currentRate * usdAmount);
}

static double VndToUsd(int vnd, int rate)
{
    return (double) vnd / rate;
}