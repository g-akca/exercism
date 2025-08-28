def is_armstrong_number(number):
    text = str(number)
    sum = 0
    
    for c in text:
        sum += int(c) ** len(text)
        
    if sum == number:
        return True
    return False