def value(colors):
    dict = {'black': 0, 'brown': 1, 'red': 2, 'orange': 3, 'yellow': 4, 'green': 5, 'blue': 6, 'violet': 7, 'grey': 8, 'white': 9}
    result = 0

    for i, color in enumerate(colors):
        result = result * 10 + dict[color]
        if i == 1:
            break

    return result