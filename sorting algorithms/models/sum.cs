namespace models
{
    public class sum
    {
        public static int getSum( params int[] nums)
        {
            int sum =0;
            for(int i =0; i< nums.GetUpperBound(0); i++)
            {
                sum+=nums[i];
            }
            return sum;
        }
    }
}