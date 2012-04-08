;; Exercise 1.3

(define (square x) (* x x))

(define (sum-of-squares x y) (+ (square x) (square y)))

(define (sum-of-two-largest-squares x y z)
  (if (>= x y) 
      (sum-of-squares x (if (>= y z) y z))
      (sum-of-squares y (if (>= x z) x z))))

;; Tests

(sum-of-two-largest-squares 2 3 4)
(sum-of-two-largest-squares 4 2 3)
(sum-of-two-largest-squares 3 4 2)