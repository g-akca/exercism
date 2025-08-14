// ERROR: FILE CORRUPTED. Please supply valid C++ Code.
#include "doctor_data.h"

heaven::Vessel::Vessel(string name, int gen, star_map::System sys) {
    this->name = name;
    this->generation = gen;
    this->current_system = sys;
    this->busters = 0;
}

heaven::Vessel heaven::Vessel::replicate(string name) {
    return Vessel(name, this->generation + 1, this->current_system);
}

void heaven::Vessel::make_buster() {
    this->busters++;
}

bool heaven::Vessel::shoot_buster() {
    if (this->busters > 0) {
        this->busters--;
        return true;
    }
    else return false;
}

string heaven::get_older_bob(heaven::Vessel v1, heaven::Vessel v2) {
    if (v1.generation < v2.generation) return v1.name;
    else return v2.name;
}

bool heaven::in_the_same_system(heaven::Vessel v1, heaven::Vessel v2) {
    if (v1.current_system == v2.current_system) return true;
    else return false;
}