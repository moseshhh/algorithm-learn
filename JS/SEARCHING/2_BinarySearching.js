// Only work with sorted array
function binarySearch(arr, x, lowIndex, highIndex) {
  if (x > arr[highIndex - 1]) {
    console.log("number you search is too big");
    return -1;
  }

  if (highIndex > lowIndex) {
    mid = Math.floor((lowIndex + highIndex) / 2);

    if (arr[mid] > x) {
      return binarySearch(arr, x, 0, mid);
    }
    if (arr[mid] < x) {
      return binarySearch(arr, x, mid, highIndex);
    }
    if (arr[mid] == x) {
      console.log(mid);
      return mid;
    }
  } else {
    console.log("ousides");
    return -1;
  }
}

binarySearch([1, 2, 3, 4, 5, 7, 8, 9, 10], 9, 0, 8);
