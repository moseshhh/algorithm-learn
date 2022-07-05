import math

def binary_searching(arr, x, low_index, high_index):
  if (low_index < high_index):
    mid = math.ceil( (low_index + high_index)/2 )
    if (x < arr[mid]):
      return binary_searching(arr, x, low_index, mid)
    if (x > arr[mid]):
      return binary_searching(arr, x, mid, high_index)
    if(arr[mid] == x):
      return mid
  return -1

print(binary_searching([1,2,3,4,5,6], 5, 0, 5))