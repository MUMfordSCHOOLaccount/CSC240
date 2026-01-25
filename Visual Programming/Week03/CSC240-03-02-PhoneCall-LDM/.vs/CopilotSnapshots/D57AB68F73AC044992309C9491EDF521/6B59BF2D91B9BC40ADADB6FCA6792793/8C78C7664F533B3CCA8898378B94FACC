using static System.Console;

class PhoneCall
{
    private static double CalcPhoneCallPrice(int minutes, double rate)
    {
        const double base_fee = 0.25;
        double call_fee;
        call_fee = base_fee + minutes * rate;
        return call_fee;
    }

    static void Main()
    {
        int[] callLengths = {2, 5};
        double[] rates = {0.03, 0.12};
        double priceOfCall;

        WriteLine("{0,10}{1,10}{2,10}", "minutes", "rate", "price");

        for (int x = 0; x < callLengths.Length; ++x)
        {
            for (int y = 0; y < rates.Length; ++y)
            {
                priceOfCall = CalcPhoneCallPrice(callLengths[x], rates[y]);
                WriteLine("{0,10}{1,10}{2,10}", callLengths[x], rates[y], priceOfCall.ToString("c"));
            }
        }
    }
}
