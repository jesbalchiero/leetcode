public class Solution {
    public bool IsPalindrome(int x) {
        int start = 0, end = x;

        while (end > 0) 
        {
            start = start * 10 + end % 10;
            end /= 10; 
        }

        return start == x;
    }
}