// Sample inputs and edge cases
string[] inputs = {
            "Abcdef!1",         // Valid input
            "Short1!",          // Matching input length
            "Toolonginput123!", // Exceeding max length
            "missinguppercase1!", // Missing uppercase
            "MISSINGLOWERCASE1!",  // Missing lowercase
            "MissingSpecialChar1", // Missing special character
            "Missingdigit!",       // Missing digit
            "  ExtraSpaces 1!  ",   // Excess whitespace characters
            "abc123",             // Missing uppercase and special character
            "ABC123",             // Missing lowercase and special character
            "Abcdefg",            // Missing digit and special character
            "ABCD1231",            // Missing lowercase and special character
        };

int maxLength = 15;

foreach (string input in inputs)
{
    bool isValid = StringValidator.ValidateString(input, maxLength);

    Console.WriteLine($"Input: {input}");
    Console.WriteLine($"Valid: {isValid}");
    Console.WriteLine();
}