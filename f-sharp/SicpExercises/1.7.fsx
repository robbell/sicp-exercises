// Exercise 1.7

let square x = x * x

let average x y = (x + y) / 2.0

let improve guess radicand = average guess (radicand / guess)

let goodEnough guess radicand = abs (square guess - radicand) < 0.001

let improvedGoodEnough guess radicand = abs (guess - improve guess radicand) < 0.001

let rec sqrtIter guess radicand = 
    if improvedGoodEnough guess radicand then guess 
    else sqrtIter (improve guess radicand) radicand

let sqrt radicand = sqrtIter 1.0 radicand

sqrt 144.0

// sqrt 10000000000000.0    // orig: infinite loop  improved: 3162277.66    actual: 3162277.66
// sqrt 0.0001              // orig: 0.03230844833  improved: 0.01012021837 actual: 0.01
// sqrt 144.0               // orig: 12.00000001    improved: 12.00054573   actual: 12.0
