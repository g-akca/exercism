#include <string>
using namespace std;

namespace log_line {
std::string message(std::string line) {
    // return the message
    int n = line.find(":");

    return line.substr(n + 2);
}

std::string log_level(std::string line) {
    // return the log level
    int f = line.find("[");
    int l = line.find("]");

    return line.substr(f + 1, l - f - 1);
}

std::string reformat(std::string line) {
    // return the reformatted message
    int n = line.find(":");
    int f = line.find("[");
    int l = line.find("]");
    
    return line.substr(n + 2) + " (" + line.substr(f + 1, l - f - 1) + ")";
}
}  // namespace log_line
