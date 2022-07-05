function linearSearch(arr, x) {
  // arr : Array
  // x  : a numbers will be search
  let i;
  let n = arr.length;
  for (i = 0; i < n; i++) {
    if (arr[i] == x) {
      return i;
    }
  }
  return -1;
}
