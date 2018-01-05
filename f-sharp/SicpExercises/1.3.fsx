// Exercise 1.3

let sumSquaresOfTwoLargest a b c = 
    let square a = a * a
    let sumOfSquares a b = square a + square b

    if a > b then sumOfSquares a (if b > c then b else c)
    else sumOfSquares b (if a > c then a else c)

sumSquaresOfTwoLargest 1 2 3 // 2^2 + 3^2 = 13