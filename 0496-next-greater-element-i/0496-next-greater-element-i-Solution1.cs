public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        var nextGreaterElements = new Dictionary<int, int>();
        var greaterElements = new Stack<int>();

        for(var i = nums2.Length - 1; i >= 0; i--){
            while(greaterElements.Count > 0 && greaterElements.Peek() <= nums2[i]) greaterElements.Pop();
            nextGreaterElements[nums2[i]] = greaterElements.Count == 0 ? -1 : greaterElements.Peek();
            greaterElements.Push(nums2[i]);
        }

        return nums1.Select(num => nextGreaterElements[num]).ToArray();
    }
}