public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int windowSum = 0; 

        for(int left = 0; left < k; left++){
            windowSum += nums[left]; 
        }

        int maxSum = windowSum; 

        for(int right = k; right < nums.Length; right++){

            windowSum += nums[right];
            windowSum -= nums[right - k]; 

            maxSum = Math.Max(maxSum, windowSum);
        }

    return (double)maxSum/k;
        
    }
}