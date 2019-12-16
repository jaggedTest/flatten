# flatten
Solution takes a jagged array in C# and flattens it into a single dimensional array honoring array position of original values.

Because C# is so strongly typed, I was unable to tests with as diversely structured array as was requested, however, I did the best I could given the constraints.

Because no request was made to optimize the code, I chose to write code as readable as possible, leveraging a list to easily build and later retrieve the result array. I am aware other structures would be more efficient in writing optimized code, however if we were truly looking for optimized performance we would not be utilizing C# for this code. Instead we would use a language like GoLang which is designed for speed.

Written by Bret Lowry
