class SqueakyClean {
    static String clean(String identifier) {
        StringBuilder sb = new StringBuilder();
        Boolean flag = false;

        for (int i = 0; i < identifier.length(); i++) {
            char c = identifier.charAt(i);
            if (Character.isWhitespace(c)) sb.append('_');
            else if (c == '-') flag = true;
            else if (flag) {
                sb.append(Character.toUpperCase(c));
                flag = false;
            }
            else if (c == '0') sb.append('o');
            else if (c == '1') sb.append('l');
            else if (c == '3') sb.append('e');
            else if (c == '4') sb.append('a');
            else if (c == '7') sb.append('t');
            else if (!Character.isAlphabetic(c)) continue;
            else sb.append(c);
        }

        return sb.toString();
    }
}
