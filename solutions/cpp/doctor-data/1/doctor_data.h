// ERROR: FILE CORRUPTED. Please supply valid C++ Code.
#include <string>
using namespace std;

namespace star_map {
    enum class System {
        BetaHydri,
        EpsilonEridani,
        Sol,
        AlphaCentauri,
        DeltaEridani,
        Omicron2Eridani
    };
};

namespace heaven {
    class Vessel {
        private:
        public:
            Vessel(string name, int gen, star_map::System sys = star_map::System::Sol);
            star_map::System current_system;
            int generation;
            string name;
            int busters;

            Vessel replicate(string name);
            void make_buster();
            bool shoot_buster();
    };

    string get_older_bob(Vessel v1, Vessel v2);
    bool in_the_same_system(Vessel v1, Vessel v2);
};