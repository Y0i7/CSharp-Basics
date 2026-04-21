
/*
Practice 1

An algorithm to validate Ip Addresses using three functions ValidateZeros, ValidateRange and
ValidateLength in order to check the the provided ip address's composition.
*/
namespace CreateMethods
{
    public class Practice2
    {
        const string ValidIPMessage = "{0} ip is a valid IPv4 address";
        const string InValidIPMessage = "{0} ip is an invalid IPv4 address";
        const int ValidMaxLength = 4;

        string[] ipv4Input = ["107.31.1.5", "255.0.0.255", "555..0.555", "255...255"];
        public static void Practice2()
        {
            foreach (var ip in ipv4Input)
            {
                var addressNumbers = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);

                var numericValues = addressNumbers
                    .Where(nV => int.TryParse(nV, out _))
                    .Select(int.Parse)
                    .ToArray();

                var validZeroes = ValidateZeros(addressNumbers);
                var validRange = ValidateRange(numericValues);
                var validLength = ValidateLength(addressNumbers);

                var isValid = validZeroes && validRange && validLength;

                Console.WriteLine(
                    isValid ? ValidIPMessage : InValidIPMessage,
                    ipv4Input
                );
            }


            static bool ValidateLength(string[] addressNumbers)
            {
                return addressNumbers.Length == ValidMaxLength;
            }

            static bool ValidateZeros(string[] addressNumbers)
            {
                foreach (var number in addressNumbers)
                {
                    if (number.Length > 1 && number.StartsWith("0"))
                        return false;
                }
                return true;
            }

            static bool ValidateRange(int[] numericValues)
            {


                foreach (var number in numericValues)
                {
                    if (number < 0 || number > 255)
                        return false;
                }
                return true;
            }
        }




    }

}
