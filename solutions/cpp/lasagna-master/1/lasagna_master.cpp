#include "lasagna_master.h"

namespace lasagna_master {
// TODO: add your solution here
    int preparationTime(vector<string> layers, int mpl) {
        return layers.size() * mpl;
    }

    amount quantities(vector<string> layers) {
        amount amounts{0, 0};
        for (auto layer : layers) {
            if (layer == "noodles") {
                amounts.noodles += 50;
            }
            else if (layer == "sauce") {
                amounts.sauce += 0.2;
            }
        }
        return amounts;
    }

    void addSecretIngredient(vector<string>& own, const vector<string>& friends) {
        own.back() = friends.back();
    }

    vector<double> scaleRecipe(vector<double> quantities, int portions) {
        for (auto& quantity : quantities) {
            quantity *= portions / 2.0;
        }

        return quantities;
    }

    void addSecretIngredient(vector<string>& own, string secret) {
        own.back() = secret;
    }
}  // namespace lasagna_master
