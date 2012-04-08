;; Exercise 1.8

#lang scheme

(define (square x) (* x x))

(define (cube x) (* x x x))

(define (improve guess the-cube)
  (/ (+ (/ the-cube (square guess))
        (* guess 2))
     3))

(define (good-enough? guess the-cube)
  (< (abs (- (improve guess the-cube) guess))
     (* guess 0.001)))

(define (cbrt-iter guess the-cube)
  (if (good-enough? guess the-cube)
      guess
      (cbrt-iter (improve guess the-cube)
                 the-cube)))

(define (cbrt x)
  (cbrt-iter 1.0 x))

;; Tests

(cbrt 27)