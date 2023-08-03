# Given a time in -hour AM/PM format, convert it to military (24-hour) time.

# Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'timeConversion' function below.
#
# The function is expected to return a STRING.
# The function accepts STRING s as parameter.
#

def timeConversion(s):
    # Write your code here
    hours, minutes, seconds = s.split(":")
    
    if "AM" in s:
        if hours == "12":
            hours = "00"
    else:
        if hours != "12":
            hours = str(int(hours) + 12)
    
    time_string = f"{hours}:{minutes}:{seconds}"
    if "AM" in s or "PM" in s:
        time_string = time_string[:-2]
            
    return time_string

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = timeConversion(s)

    fptr.write(result + '\n')

    fptr.close()
