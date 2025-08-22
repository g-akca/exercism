#include "reverse_string.h"

namespace reverse_string {

// TODO: add your solution here
    string reverse_string(string s) {
        string reversed;
        for (int i = s.length() - 1; i >= 0; i--) {
            reversed += s[i];
        }
        return reversed;
    }

}  // namespace reverse_string
