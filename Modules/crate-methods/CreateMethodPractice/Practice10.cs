/*
This programs allows toy to create an email address based on names and lastnames
*/

const string ExternalDomain = "@hayworth.com";
const string InternalDomain = "@contoso.com";

const string ErrorMessage = "Someting went gront at {0},{1} index";
const string ShowingEmailFormat = "-> {0}";

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

ShowInternalEmails(corporate, InternalDomain);
ShowExternalEmails(external, ExternalDomain);

void ShowInternalEmails(string[,] corporate, string internalDomain)
{
    var corporatedEmails = new string[corporate.GetLength(0)];
    var emailCompose = "";

    for (var i = 0; i < corporate.GetLength(0); i++)
    {
        for (var j = 0; j < corporate.GetLength(1); j++)
        {
            switch (j)
            {
                case 0:
                    emailCompose = corporate[i, j][..2].ToLower();
                    break;

                case 1:
                    emailCompose += corporate[i, j].ToLower();
                    break;
                default:
                    Console.Write(
                        ErrorMessage,
                        i,
                        j
                    );
                    break;
            }
        }
        corporatedEmails[i] = emailCompose + InternalDomain;
    }

    foreach (var email in corporatedEmails)
        Console.WriteLine(
            ShowingEmailFormat,
            email
        );
}


void ShowExternalEmails(string[,] external, string externalDomain)
{
    var externalEmails = new string[external.GetLength(0)];
    var emailCompose = "";

    for (var i = 0; i < external.GetLength(0); i++)
    {
        for (var j = 0; j < external.GetLength(1); j++)
        {
            switch (j)
            {
                case 0:
                    emailCompose = external[i, j][..2].ToLower();
                    break;

                case 1:
                    emailCompose += external[i, j].ToLower();
                    break;
                default:
                    Console.Write(
                        ErrorMessage,
                        i,
                        j
                    );
                    break;
            }
        }
        externalEmails[i] = emailCompose + ExternalDomain;
    }

    foreach (var email in externalEmails)
        Console.WriteLine(
            ShowingEmailFormat,
            email
        );
}
