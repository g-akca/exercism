class Badge {
    public String print(Integer id, String name, String department) {
        String label = "";
        if (id != null) label = "[" + id + "] - ";
        
        label += name + " - ";
        
        if (department != null) label += department.toUpperCase();
        else label += "OWNER";
        
        return label;
    }
}
