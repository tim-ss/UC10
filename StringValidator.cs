using System.Text.RegularExpressions;

public class StringValidator
{
    public static bool ValidateString(string input, int maxLegth)
    {
        string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@[\]^_`{|}~])\S{1,%s}$";
        pattern = pattern.Replace("%s", maxLegth.ToString());
        Regex regex = new Regex(pattern);

        return regex.IsMatch(input);
    }
}