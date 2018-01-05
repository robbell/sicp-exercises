// Exercise 1.3

let square a = a * a

let sumOfSquares a b = square a + square b

let sumSquaresOfTwoLargest a b c = 
    if a > b then sumOfSquares a c
    else if a > c then sumOfSquares a b
    else sumOfSquares b c
