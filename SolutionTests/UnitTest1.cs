using Find_Pivot_Index;
using Xunit;

namespace SolutionTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] {1,7,3,6,5,6},3)]
        [InlineData(new int[] {1,2,3},-1)]
        [InlineData(new int[] {2,1,-1},0)]
        public void TestPivotIndex(int[] nums, int expected)
        {
            Solution solution = new Solution();

            //Act
            int actual = solution.PivotIndex(nums);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}