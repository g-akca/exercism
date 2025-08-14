#pragma once
#include <string>
#include <vector>
using namespace std;

namespace lasagna_master {
    struct amount {
        int noodles;
        double sauce;
    };

    int preparationTime(vector<string> layers, int mpl = 2);
    amount quantities(vector<string> layers);
    void addSecretIngredient(vector<string>& own, const vector<string>& friends);
    vector<double> scaleRecipe(vector<double> quantities, int portions);
    void addSecretIngredient(vector<string>& own, string secret);

}  // namespace lasagna_master
