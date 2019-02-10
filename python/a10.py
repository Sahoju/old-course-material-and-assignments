# Write a function, called largest, that is given a list of numbers
# and the function returns the largest number in the list.

def Largest(nums):
    count = 0
    largest = 0
    for i in nums:
        if largest < nums[count]: # i = the number in the table, not the index
            largest = i
        count += 1
    print(largest)




nums = [5,2,3,7,1]
print(nums)
Largest(nums)
print(max(nums)) # an easier way, for reference purposes
