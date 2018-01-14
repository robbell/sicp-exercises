// Exercise 1.8

let average x y = (x + y) / 2.0

let improve guess radicand = (radicand / guess ** 2.0 + 2.0 * guess) / 3.0

//let goodEnough guess radicand = guess = improve guess radicand
let goodEnough guess radicand = abs (guess - improve guess radicand) < 0.001

let rec cbrtIter guess radicand = 
    if goodEnough guess radicand then guess 
    else cbrtIter (improve guess radicand) radicand

let cbrt radicand = cbrtIter 1.0 radicand

cbrt 256.0

// call                     mine            actual
// cbrt 999.0               9.996665697     9.99666555494
// cbrt 1000.0              10.00000015     10
// cbrt 0.0001              0.04681032165   0.04641588833
// cbrt 10000000000000.0    21544.34695     21544.3469003
