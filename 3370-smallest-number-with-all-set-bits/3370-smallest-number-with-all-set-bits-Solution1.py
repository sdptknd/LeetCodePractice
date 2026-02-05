class Solution:
    def smallestNumber(self, n: int) -> int:
        exactPower = math.log2(n + 1)
        return (2 ** math.ceil(exactPower)) - 1
        