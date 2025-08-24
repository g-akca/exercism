#include "triangle.h"

namespace triangle {

// TODO: add your solution here
    flavor kind(double a, double b, double c) {
        if (a <= 0 || b <= 0 || c <= 0) {
            throw domain_error("Negative or zero sides");
        }
        else if (a + b < c || a + c < b || b + c < a) {
            throw domain_error("Invalid triangle");
            }
        else if (a == b && b == c) {
            return flavor::equilateral;
        }
        else if (a == b || b == c || a == c) {
            return flavor::isosceles;
        }
        else {
            return flavor::scalene;
        }
    }
}  // namespace triangle
