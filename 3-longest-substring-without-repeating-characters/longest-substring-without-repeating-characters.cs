public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0; 
        int max = 0;
        HashSet<char> window = new HashSet<char>(); 

        for(int right = 0; right < s.Length; right++) {
            while(window.Contains(s[right])){
                window.Remove(s[left]);
                left++; 
            }

            window.Add(s[right]); 
            int currentLength = right - left + 1; 
            max = Math.Max(currentLength, max);

        }
        return max;         
    }
}