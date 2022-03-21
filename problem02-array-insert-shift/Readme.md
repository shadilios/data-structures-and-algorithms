The actual code and solution are in a console app [Here](./insert-shift-array)

# Insert-Shift-Array

## Description:
Writing a function that would insert a number into an array, and shift elements that come after that number with one index ahead.
<br><br><hr>

## Whiteboard Process:

![Image](./insert-shift-array.png)
<br><br><hr>

## Approach & Effeciency:

I pass the array that I want to edit into a function in addition to the element we want to add, I create a new empty array inside my function that has the length of the old array + 1.  
Now we loop over the empty array and using logic with if statements we can create a new array using our old one & the element we are adding.

The effeciency should be O(N) since we enter the array once.
