arr = [9, 1, 8, 7, 3, 6, 4, 5]

for i in range (len(arr)):
    min = float('inf')
    for j in range (i, len(arr)):
        if (arr[j] < min):
            min = arr[j]
            index_min = j

    buffer = arr[i]
    arr[i] = min
    arr[index_min] = buffer

print(f'Sorted array: {arr}')