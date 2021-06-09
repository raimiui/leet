using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace mstests
{
    [TestClass]
    public class TwoSum
    {
        [TestMethod]
        [DataRow(new[]{1,2,3}, 4, new[]{0,2})]
        public void TestMethodas(int[] nums, int target, int[] expectedOutput)
        {
            var e = new Exercise();
            var output = e.TwoSum(nums, target);
            Assert.IsTrue(output[0] == expectedOutput[0]);
            Assert.IsTrue(output[1] == expectedOutput[1]);
        }
        public class Exercise
        {
            public int[] TwoSum(int[] nums, int target) {
                // iterate through nums
                for(var i = 0; i < nums.Length; i++){
                    // check if currElem sums up to target with any of subsequent elements
                    for(var j = i + 1; j < nums.Length; j++){
                        // return when found
                        if(nums[i] + nums[j] == target)
                            return new []{i, j};
                    }
                }

                return new []{0, 0};
            }
        }
    }

}
