def Koira(nums):
    summer = 0
    for i in nums:
        summer += i
    return summer

nums = [1,2,3,4,5]
print(Koira(nums))
print(sum(nums)) # Python has a function for summing, too!
