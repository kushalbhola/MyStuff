//https://leetcode.com/problems/longest-substring-without-repeating-characters/
//https://leetcode.com/problems/longest-repeating-character-replacement/
package Leetcode;

import java.util.HashSet;

public class LongestSubstringWithoutRepeating
{
    public static void main(String[] args) {
        String input = "abcabcbb";
        LongestSubstringWithoutRepeating a = new LongestSubstringWithoutRepeating();
        int result = a.lengthOfLongestSubstring(input);

        String input2 = "AABABBA";
        result = a.characterReplacement(input2, 1);
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
    public int characterReplacement(String s, int k) {
        if (s.length() == 0) {
            return 0;
        }
        int start = 0;
        int len = s.length();
        int[] count = new int[26];
        int maxCount = 0;
        int rst = 0;
        for (int i = 0; i < len; i++) {
            char a = s.charAt(i);
            int b = a - 'A';
            maxCount = Math.max(maxCount, ++count[s.charAt(i) - 'A']);
            while (i - start + 1 - maxCount > k) {
                maxCount = Math.max(maxCount, --count[s.charAt(start) - 'A']);
                start++;
            }
            rst = Math.max(rst, i - start + 1);
        }
        return rst;
    }
}