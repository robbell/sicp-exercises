// Exercise 1.9 - Part 2
// Recursive procedure, iterative process

// (define (+ a b)
//   (if (= a 0) 
//       b 
//       (+ (dec a) (inc b))))

let inc x = x + 1

let dec x = x - 1

let inline (+) a b = 
    if a = 0 then b
    else (dec a) + inc(b)

// 4 + 5
// (dec 4) + inc(5)
// 3 + 6
// (dec 3) + inc(6)
// 2 + 7
// (dec 2) + inc(7)
// 1 + 8
// (dec 1) + inc(8)
// 0 + 9
// 9

4 + 5 // 9
