string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(') + 1;
int closingPosition = message.IndexOf(')');

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

Console.ReadKey();
Console.Clear();


string message2 = "What is the value <span>between the tags</span>?";

int openingPosition2 = message2.IndexOf("<span>");
int closingPosition2 = message2.IndexOf("</span>");

openingPosition2 += 6;
int length2 = closingPosition2 - openingPosition2;
Console.WriteLine(message2.Substring(openingPosition2, length2));

Console.ReadKey();
Console.Clear();

string message3 = "What is the value <span>between the tags</span>?";

const string openSpan3 = "<span>";
const string closeSpan3 = "</span>";

int openingPosition3 = message.IndexOf(openSpan3);
int closingPosition3 = message.IndexOf(closeSpan3);

openingPosition3 += openSpan3.Length;
int length3 = closingPosition3 - openingPosition3;
Console.WriteLine(message3.Substring(openingPosition3, length));