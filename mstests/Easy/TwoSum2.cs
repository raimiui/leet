using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace mstests
{
    [TestClass]
    public class TwoSum2
    {
        [TestMethod]
        [DataRow(new[]{-1,0}, -1, new[]{1,2})]
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

                var checkedValues = new List<int>();

                // iterate through nums
                for(var i = 0; i < nums.Length; i++){

                    if(checkedValues.Contains(nums[i]))
                        continue;
                    else
                        checkedValues.Add(nums[i]);

                    // check if currElem sums up to target with any of subsequent elements
                    for(var j = i + 1; j < nums.Length; j++){
                        // return when found
                        if(nums[i] + nums[j] == target)
                            return new []{i+1, j+1};
                    }
                }

                return new []{0, 0};
            }
        }
    }
}
