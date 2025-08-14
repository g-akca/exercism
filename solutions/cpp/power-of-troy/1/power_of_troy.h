#pragma once
#include <string>
#include <memory>
using namespace std;

namespace troy {

    struct artifact {
        // constructors needed (until C++20)
        artifact(std::string name) : name(name) {}
        std::string name;
    };
    
    struct power {
        // constructors needed (until C++20)
        power(std::string effect) : effect(effect) {}
        std::string effect;
    };
    
    struct human {
        human() : possession(nullptr), own_power(nullptr), influenced_by(nullptr) {};
        unique_ptr<artifact> possession;
        shared_ptr<power> own_power;
        shared_ptr<power> influenced_by;
    };

    void give_new_artifact(human& h, string name);
    void exchange_artifacts(unique_ptr<artifact>& a1, unique_ptr<artifact>& a2);
    void manifest_power(human& h, string effect);
    void use_power(human& caster, human& target);
    int power_intensity(human& h);

}  // namespace troy
