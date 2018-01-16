// Exercise 1.9 - Part 1
// Recursive procedure, recursive process

// (define (+ a b)
//   (if (= a 0) 
//       b 
//       (inc (+ (dec a) b))))

let inc x = x + 1

let dec x = x - 1

let inline (+) a b = 
    if a = 0 then b
    else inc((dec a) + b)

// 4 + 5
// inc((dec 4) + 5)
// inc(3 + 5)
// inc(inc((dec 3) + 5))
// inc(inc(2 + 5))
// inc(inc(inc((dec 2) + 5)))
// inc(inc(inc(1 + 5)))
// inc(inc(inc(inc((dec 1) + 5))))
// inc(inc(inc(inc(0 + 5))))
// inc(inc(inc(inc(5))))
// inc(inc(inc(6)))
// inc(inc(7))
// inc(8)
// 9

4 + 5
