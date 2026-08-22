public class Solution {
    public bool hasDuplicate(int[] nums) {

        HashSet<int> uniqueNumbers = new HashSet<int>();

        foreach(var i in nums){
            bool val = uniqueNumbers.Add(i);

            if(val == false){
                return true;
            }
        }
        return false;
    }
}