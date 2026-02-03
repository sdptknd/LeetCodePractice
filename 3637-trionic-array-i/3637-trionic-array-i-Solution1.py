class Solution:
    def isTrionic(self, nums: List[int]) -> bool:
        p, q = 0, len(nums) - 1

        while(p < len(nums) - 3 and nums[p+1] > nums[p]):
            p += 1

        if(p == 0):
            return False

        while(q > 2 and nums[q-1] < nums[q]):
            q -= 1

        if(q == len(nums) - 1 or q <= p):
            return False

        for i in range(p, q):
            if nums[i] <= nums[i+1]:
                return False

        return True
        