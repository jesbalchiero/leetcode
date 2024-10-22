using System;
using System.Collections.Generic;

public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanosInt = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            if (i < s.Length - 1 && romanosInt[s[i]] < romanosInt[s[i + 1]]) {
                result -= romanosInt[s[i]];
            } else {
                result += romanosInt[s[i]];
            }
        }

        return result;
    }
}