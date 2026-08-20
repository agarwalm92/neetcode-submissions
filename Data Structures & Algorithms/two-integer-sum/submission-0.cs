public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++){

            int compt = target - nums[i];

            if(dict.ContainsKey(compt)){
                return new int[] {dict[compt], i};
            }
            dict.TryAdd(nums[i], i);
        }
        return new int[0];
    }
}
