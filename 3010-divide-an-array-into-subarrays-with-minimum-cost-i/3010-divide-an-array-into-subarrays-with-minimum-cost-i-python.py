class Solution(object):
    def minimumCost(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        m1, m2 = sys.maxsize, sys.maxsize

        for num in nums[1:]:
            if num < m1:
                m1, m2 = num, m1
            elif num < m2:
                m2 = num
        
        return nums[0] + m1 + m2