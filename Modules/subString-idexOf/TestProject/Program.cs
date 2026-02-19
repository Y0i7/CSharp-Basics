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

// IndexOf - LastIndexOf Functions

Console.ReadKey();
Console.Clear();

var message4 = "Hello tHere";

var first_h = message4.IndexOf("h", StringComparison.CurrentCultureIgnoreCase);
var last_h = message4.LastIndexOf("h", StringComparison.CurrentCultureIgnoreCase);

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

//second example

Console.ReadKey();
Console.Clear();

string message5 = "(What if) I am (only interested) in the last (set of parentheses)?";

var openValue1 = "(";
var closeValue1 = ")";

var openingPosition5 = message5.LastIndexOf(openValue1);
openingPosition5 += openValue1.Length;

var closingPosition5 = message5.LastIndexOf(closeValue1);

var newLength5 = closingPosition5 - openingPosition5;

Console.WriteLine(message5.Substring(openingPosition5, newLength5));

// EXCERSCISE:
Console.ReadKey();
Console.Clear();

string message6 = "(What if) there are (more than) one (set of parentheses)?";

while (true)
{
    var openValue2 = "(";
    var closeValue2 = ")";

    var openingPosition6 = message6.IndexOf(openValue2, StringComparison.CurrentCultureIgnoreCase);
    if (openingPosition6 == -1)
        break;
    
    openingPosition6 += openValue2.Length;

    var closingPosition6 = message6.IndexOf(closeValue2, StringComparison.CurrentCultureIgnoreCase);
    
    var newLenght6 = closingPosition6 - openingPosition6;

    Console.WriteLine(message6.Substring(openingPosition6, newLenght6));
    message6 = message6.Substring(closingPosition6 + closeValue2.Length);
} 

// IndexOfAny Method:

var message7 = "Hello, world!";
var charsToFind = new char[]{'a', 'e', 'i' };

var index = message7.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

// Example:

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    var matchingSymbol = currentSymbol switch
    {
        "[" => ']',
        "{" => '}',
        "(" => ')',
        _ => ' '
    };
    
    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}