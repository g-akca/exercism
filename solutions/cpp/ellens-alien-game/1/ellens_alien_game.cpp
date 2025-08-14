namespace targets {
// TODO: Insert the code for the alien class here
    class Alien {
        private:
            int health;
        public:
            int x_coordinate;
            int y_coordinate;
    
            Alien(int x, int y);
            int get_health();
            bool hit();
            bool is_alive();
            bool teleport(int x_new, int y_new);
            bool collision_detection(Alien a);
    };

    Alien::Alien(int x, int y) {
        this->x_coordinate = x;
        this->y_coordinate = y;
        this->health = 3;
    }

    int Alien::get_health() {
        return this->health;
    }

    bool Alien::hit() {
        if (this->health > 0) {
            this->health--;
        }
        return true;
    }

    bool Alien::is_alive() {
        if (this->health == 0) return false;
        else return true;
    }

    bool Alien::teleport(int x_new, int y_new) {
        this->x_coordinate = x_new;
        this->y_coordinate = y_new;
        return true;
    }

    bool Alien::collision_detection(Alien a) {
        if (this->x_coordinate == a.x_coordinate && this->y_coordinate == a.y_coordinate) return true;
        else return false;
    }
}  // namespace targets