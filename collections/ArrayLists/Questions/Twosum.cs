namespace collections.ArrayLists.Questions
{
    public class Twosum
    {
        public int[] TwoSum(int[] nums,int target)
        {
            int i =0;
            for(int j=0; j< nums.Length;j++)
            {
                if(nums[i]+nums[j] == target)
                {
                    return new int[] {j,i};
                }
                i+=1;
            }
                return new int[0];

        }

    
        
    }
}