// Exercise 1.13

let phi  = (1.0 + sqrt 5.0) / 2.0
let psi  = (1.0 - sqrt 5.0) / 2.0

let fib n = 
    let rec fibIter a b count =
        if count = 0 then b
        else fibIter (a + b) a (count - 1)
    fibIter 1 0 n

let f n =
    (phi ** n) / sqrt 5.0


let f2 n =
    ((phi ** n) - (psi ** n)) / sqrt 5.0
