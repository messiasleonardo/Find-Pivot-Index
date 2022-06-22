namespace Find_Pivot_Index
{
    public class Solution
    {
        int _left = 0;
        int _right = 0;
        int _index = 0;
        public int PivotIndex(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                bool valid = ExpectedMiddleArray(i, nums);
                _left = 0;
                _right = 0;
                if (valid)
                {
                    return _index;
                }
            }


            return -1;
        }

        private bool ExpectedMiddleArray(int index, int[] nums)
        {
            if (index - 1 >= 0)
            {
                for (int i = index - 1; i >= 0; i--)
                {
                    _left += nums[i];
                }
            }


            for (int i = index + 1; i < nums.Length; i++)
            {
                _right += nums[i];
            }

            if (_left == _right)
            {
                _index = index;
                return true;
            }
            return false;
            

        }
    }
}