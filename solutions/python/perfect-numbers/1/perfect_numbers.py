import math

def classify(number):
    """ A perfect number equals the sum of its positive divisors.

    :param number: int a positive integer
    :return: str the classification of the input integer
    """
    if number < 1:
        raise ValueError("Classification is only possible for positive integers.")
        
    aliquot_sum = 0
    for i in range(1, math.floor(math.sqrt(number) + 1)):
        if number % i == 0 and number != i:
            aliquot_sum += i
            if number / i != number and number / i != i:
                aliquot_sum += number / i

    if aliquot_sum == number:
        return "perfect"
    elif aliquot_sum > number:
        return "abundant"
    elif aliquot_sum < number:
        return "deficient"