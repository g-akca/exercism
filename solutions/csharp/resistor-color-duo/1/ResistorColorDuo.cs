public static class ResistorColorDuo
{
    public static int ColorCode(string color)
    {
        switch (color) {
            case "black":
                return 0;
            case "brown":
                return 1;
            case "red":
                return 2;
            case "orange":
                return 3;
            case "yellow":
                return 4;
            case "green":
                return 5;
            case "blue":
                return 6;
            case "violet":
                return 7;
            case "grey":
                return 8;
            case "white":
                return 9;
        }
        return -1;
    }
    
    public static int Value(string[] colors) {
        if (colors.Length == 1) {
            return ColorCode(colors[0]);
        }
        return ColorCode(colors[0]) * 10 + ColorCode(colors[1]);
    }
}
