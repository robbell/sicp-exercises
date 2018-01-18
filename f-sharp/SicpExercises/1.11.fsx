// Exercise 1.11

let rec fib n = 
    if n = 0 then 0
    else if n = 1 then 1
    else fib (n - 1) + fib (n - 2)

let rec fibIter a b count = 
    if count = 0 then b
    else fibIter (a + b) a (count - 1)

let fibIt n = fibIter 1 0 n

fib 7
fibIt 7