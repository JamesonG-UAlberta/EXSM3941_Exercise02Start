using System.Text.RegularExpressions;

bool TestValidEmail(string email)
// Tests to ensure the phone number entered follows the format mask "text@text.text".  Returns true if so, and false if not.
// Rules special characters other than periods and underscores as invalid.
{
    return new Regex(@"^[\w.]+@[\w.]+[\w]+$").IsMatch(email);
}
bool TestValidPhoneNumber(string phone)
// Tests to ensure the phone number entered follows the format mask "###-###-####".  Returns true if so, and false if not.
{
    return new Regex(@"^\d{3}-d{3}-d{4}$").IsMatch(phone);
}
bool TestValidNumber(int number)
// Tests to ensure the number entered is between 1 and 100 inclusive. Returns true if so, and false if not.
{
    return number >= 1 && number <= 100;
}