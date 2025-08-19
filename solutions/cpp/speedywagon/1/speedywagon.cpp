#include "speedywagon.h"

namespace speedywagon {

// Enter your code below:
bool connection_check(pillar_men_sensor* sensor) {
    if (sensor != nullptr) return true;
    else return false;
}

int activity_counter(pillar_men_sensor* first_sensor, int n) {
    int total = 0;
    for (int i = 0; i < n; i++) {
        total += first_sensor->activity;
        first_sensor++;
    }
    return total;
}

bool alarm_control(pillar_men_sensor* sensor) {
    if (sensor != nullptr && sensor->activity > 0) return true;
    else return false;
}

bool uv_alarm(pillar_men_sensor* sensor) {
    if (sensor != nullptr && uv_light_heuristic(&sensor->data) > sensor->activity) return true;
    else return false;
}
    
// Please don't change the interface of the uv_light_heuristic function
int uv_light_heuristic(std::vector<int>* data_array) {
    double avg{};
    for (auto element : *data_array) {
        avg += element;
    }
    avg /= data_array->size();
    int uv_index{};
    for (auto element : *data_array) {
        if (element > avg) ++uv_index;
    }
    return uv_index;
}

}  // namespace speedywagon
