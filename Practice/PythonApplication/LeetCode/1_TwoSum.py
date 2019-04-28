class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
		dict = {}
		for i,v in enumerate(nums):
			if(v not in dict):
				dict[nums[i]] = i

		for i in range(len(nums)):
			currtarget = target - nums[i]
			if(currtarget in dict and i != dict[target - nums[i]]):
				return [i, dict[target - nums[i]]]
		return []




