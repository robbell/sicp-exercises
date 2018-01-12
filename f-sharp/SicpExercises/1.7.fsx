// Exercise 1.7

let square x = x * x

let average x y = (x + y) / 2.0

let improve guess radicand = average guess (radicand / guess)

let goodEnough guess radicand = abs (square guess - radicand) < 0.001

let rec sqrtIter guess radicand = 
    if goodEnough guess radicand then guess 
    else sqrtIter (improve guess radicand) radicand

let sqrt radicand = sqrtIter 1.0 radicand

sqrt 144.0 // 12.00000001