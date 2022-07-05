# x number search
#  arr => list / array
def linear_search(x, arr = []):
  array_length = len(arr)
  for i in range(0, array_length):
    if arr[i] == x :
      return i
  
  return -1


