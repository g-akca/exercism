def response(hey_bob):
    if hey_bob.isspace() or hey_bob == "":
        return "Fine. Be that way!"
    elif hey_bob.strip(" ")[-1] == '?':
        if hey_bob.isupper():
            return "Calm down, I know what I'm doing!"
        return "Sure."
    elif hey_bob.isupper():
        return "Whoa, chill out!"
    return "Whatever."
