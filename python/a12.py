# Write a function called sum2 that takes a number
# and sums all the numbers starting from 0 up to that number.

def Sum2(stuff):
    sum2 = 0
    while stuff != 0:
        sum2 += stuff
        stuff -= 1
    print(sum2)
    

stuff = 10
Sum2(stuff)
stuff = 5
Sum2(stuff)
stuff = 50
Sum2(stuff)
