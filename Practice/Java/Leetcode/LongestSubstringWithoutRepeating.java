//https://leetcode.com/problems/longest-substring-without-repeating-characters/
package Leetcode;

import java.util.HashSet;

public class LongestSubstringWithoutRepeating
{
    public static void main(String[] args) {
        String input = "abcabcbb";
        LongestSubstringWithoutRepeating a = new LongestSubstringWithoutRepeating();
        int result = a.lengthOfLongestSubstring(input);
    }
    public int lengthOfLongestSubstring(String s) {
        if(s.length() == 0 || s.length() == 1)
            return s.length();
        int start = 0;
        int end = 0;
        char[] ch = s.toCharArray();
        HashSet<Character> hash = new HashSet<>();
        int ans = 0;
        while(start < ch.length && end < ch.length){
            if(!hash.contains(ch[end]))
            {
                hash.add(ch[end++]);
            }
            else{
                hash.remove(ch[start++]);
            }
            ans = Math.max(ans, end-start);
        }
        return ans;
    }
}