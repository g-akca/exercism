#include "leap.h"

namespace leap {

// TODO: add your solution here
bool is_leap_year(int year) {
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
        return true;
    }
    else return false;
}
    
}  // namespace leap
