public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // COMPLEXITY O(N^2)
        /* for(int i = 0; i <= nums.Length - 1 ; i++){
            for(int j = 1; j <= nums.Length - 1 - i; j++){
                if((nums[i] + nums[i+j]) == target){
                    return [i, i+j];
                } 
            }
        }
        return []; */

        // COMPLEXITY O(N)
        var seen = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];

            if (seen.TryGetValue(diff, out int j)){
                return [j, i];
            }

            seen[nums[i]] = i;
        }

        return [];
    } 
}

