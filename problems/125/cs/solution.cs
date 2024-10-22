using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string str) {
        str = RemoveNonAlphanumeric(str).ToLower();
        string reversedStr = ReverseString(str);
        return str == reversedStr;
    }

    private string RemoveNonAlphanumeric(string str)
    {
        string pattern = "[^a-zA-Z0-9]";
        return Regex.Replace(str, pattern, "");
    }

    private string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}