def label(colors):
    BANDS = ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"]
    
    ohms = (10 * BANDS.index(colors[0]) + BANDS.index(colors[1])) * (10 ** BANDS.index(colors[2]))
    
    if ohms > 1000000000:
        prefix = "giga"
        ohms //= 1000000000
    elif ohms > 1000000:
        prefix = "mega"
        ohms //= 1000000
    elif ohms > 1000:
        prefix = "kilo"
        ohms //= 1000
    else:
        prefix = ""
    
    return f"{ohms} {prefix}ohms"