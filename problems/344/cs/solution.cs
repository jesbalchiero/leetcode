public class Solution {
    public void ReverseString(char[] chars) {
        int start = 0;
        int end = chars.Length - 1;

        while (start < end)
        {
            char temp = chars[start];
            chars[start] = chars[end];
            chars[end] = temp;

            start++;
            end--;
        }
    }
}