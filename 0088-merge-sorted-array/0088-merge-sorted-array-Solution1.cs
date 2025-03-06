public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m-1, j = nums1.Length -1, k = n-1;

        while(i >= 0 && k >= 0){
            if(nums1[i] > nums2[k]) nums1[j--] = nums1[i--];
            else nums1[j--] = nums2[k--];
        }

        while(k >= 0) nums1[j--] = nums2[k--];
    }
}