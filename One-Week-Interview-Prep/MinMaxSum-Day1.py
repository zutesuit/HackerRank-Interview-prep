# Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'miniMaxSum' function below.
#
# The function accepts INTEGER_ARRAY arr as parameter.
#

def miniMaxSum(arr):
    # Write your code here
    sorted_array = sorted(arr)
    min_sum = sum(sorted_array[:4])
    max_sum = sum(sorted_array[1:])
    # return min_sum, max_sum
    #print(f"{min_sum, max_sum}")
    print (min_sum, max_sum)
    
if __name__ == '__main__':

    arr = list(map(int, input().rstrip().split()))

    miniMaxSum(arr)
