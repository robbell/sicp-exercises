// Exercise 1.10

let rec A x y = 
    if y = 0 then 0
    else if x = 0 then 2 * y
    else if y = 1 then 2
    else A (x - 1) (A x (y - 1))

(A 1 10) // 1024
(A 2 4) // 65536
(A 3 3) // 65536

// Part 2

let f n = (A 0 n) // 2n

let g n = (A 1 n) // 2^n

let h n = (A 2 n) // 2^2^... n-1 times
