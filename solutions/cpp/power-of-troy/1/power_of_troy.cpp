#include "power_of_troy.h"

namespace troy {
    void give_new_artifact(human& h, string name) {
        h.possession = make_unique<artifact>(name);
    }

    void exchange_artifacts(unique_ptr<artifact>& a1, unique_ptr<artifact>& a2) {
        swap(a1, a2);
    }

    void manifest_power(human& h, string effect) {
        h.own_power = make_shared<power>(effect);
    }

    void use_power(human& caster, human& target) {
        target.influenced_by = caster.own_power;
    }

    int power_intensity(human& h) {
        if (h.own_power == nullptr) {
            return 0;
        }
        else {
            return h.own_power.use_count();
        }
    }
}  // namespace troy
