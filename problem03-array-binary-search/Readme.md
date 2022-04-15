The actual code and solution are in a console app [Here](https://github.com/shadilios/data-structures-and-algorithms/tree/main/problem03-array-binary-search/array-binary-search)

# Array-Binary-Search

## Description:
Writing a function that takes a sorted array and a key value, if the key exists in the array return the index of the value, if not return -1.
<br><br><hr>

## Whiteboard Process:

![Image](https://github.com/shadilios/data-structures-and-algorithms/blob/main/problem03-array-binary-search/array-binary-search.png)
<br><br><hr>

## Approach & Effeciency:

I Loop over my array, if the element is found return its index, if not return the default value I set before which is -1;
I also break if the first condition is met so that I don't loop over the whole array.

In this situation we use O(n).
