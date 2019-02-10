# Write a function, called reverse,
# that is given a list and it returns the list in reverse order.

def Reverse(stuff):
    stuff_reversed = [0,0,0,0]
    count = len(stuff) # gets the length of the list
    for i in stuff:
        stuff_reversed[count-1] = i
        count -= 1
    print(stuff_reversed)
    


stuff = [1,2,3,4]
print(stuff)
Reverse(stuff)
# slicing the list, for reference purposes
print(stuff[::-1]) # syntax: list[start:stop:stride]
stuff.reverse() # function for reversing the list, for reference purposes
print(stuff) # can not type "print(stuff.reverse())", need to separate them
