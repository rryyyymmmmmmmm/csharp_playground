public static class PasswordValidator
{
    //attribute-less class, static even
    private static bool sizeIsValid(string input) {
        if(input.Length >= 6 && input.Length <= 13 ) return true;
        else return false;
    }

    private static bool containsValid(string input) {
        bool upper=false, lower=false, digit=false;
        foreach(char c in input) {
            if(char.IsUpper(c)) upper = true;
            if(char.IsDigit(c)) digit = true;
            if(char.IsLower(c)) lower = true; 
            if(c.Equals('T') || c.Equals('&')) return false;
        }
        if(upper && digit && lower) return true;
        else return false;
    }
    private static bool isValid(string input) {
        if(sizeIsValid(input) && containsValid(input)) return true;
        else return false;
    }

    public static void validator(string input) {
        if(isValid(input)) {
            Console.WriteLine("password is valid.");
        } else {
            Console.WriteLine("password is not valid.");
        }
    }
}