import math

def score(x, y):
    dist = math.sqrt((x * x) + (y * y))
    if dist <= 1:
        return 10
    elif dist <= 5:
        return 5
    elif dist <= 10:
        return 1
    return 0
