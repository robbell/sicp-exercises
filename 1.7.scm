;; Exercise 1.7

#lang scheme

(define (square x) (* x x))

(define (average x y)
  (/ (+ x y) 2))

(define (improve guess the-square)
  (average guess (/ the-square guess)))

;; Previous 'good-enough?' implementation wasn't tolerant to smaller roots

#;(define (good-enough? guess the-square)
  (< (abs (- (square guess) the-square)) 0.001))

;; New implementation makes the check between the current guess and the next

(define (good-enough? guess the-square)
  (< (abs (- (improve guess the-square) guess))
     (* guess 0.001)))

(define (sqrt-iter guess the-square)
  (if (good-enough? guess the-square)
      guess
      (sqrt-iter (improve guess the-square)
                 the-square)))

(define (sqrt x)
  (sqrt-iter 1.0 x))

;; Tests

(sqrt 0.0001)
;; Old method:     0.03230844833048122
;; New method:     0.010000714038711746
;; Correct answer: 0.01