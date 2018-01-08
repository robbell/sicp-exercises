let square x = x * x

let sumOfSquares x y = square(x) + square(y)

let f a = sumOfSquares (a + 1) (a * 2)

// Substitution Model (Applicative Order) - avoids multiple evaluations

// sumOfSquares (5 + 1) (5 * 2)
// sumOfSquares (6) (10)
// square (6) + square (10)
// (6 * 6) + (10 * 10)
// 36 + 100
// 136

// Normal Order

// sumOfSquares (5 + 1) (5 * 2)
// square (5 + 1) + square (5 * 2)
// ((5 + 1) * (5 + 1)) + ((5 * 2) * (5 * 2))
// (6 * 6) + (10 * 10)
// 36 + 100
// 136
