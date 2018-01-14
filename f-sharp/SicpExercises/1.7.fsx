// Exercise 1.7

let square x = x * x

let average x y = (x + y) / 2.0

let improve guess radicand = average guess (radicand / guess)

let goodEnough guess radicand = abs (square guess - radicand) < 0.001

let goodEnoughImproved guess radicand = abs (guess - improve guess radicand) < 0.001

let goodEnoughExact guess radicand = guess = improve guess radicand

let rec sqrtIter guess radicand = 
    if goodEnoughExact guess radicand then guess 
    else sqrtIter (improve guess radicand) radicand

let sqrt radicand = sqrtIter 1.0 radicand

sqrt 144.0

// function call            original        improved        exact       actual
// sqrt 10000000000000.0    infinite loop   3162277.66      3162277.66  3162277.66
// sqrt 0.0001              0.03230844833   0.01012021837   0.01        0.01
// sqrt 144.0               12.00000001     12.00054573     12.0        12.0
