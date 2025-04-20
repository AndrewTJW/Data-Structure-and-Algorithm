arr = [1, 8, 9, 2, 7, 3, 6, 4, 5]


for i in range (len(arr) - 1):
    swapped = False
    for j in range (len(arr) - 1 - i):
        if (arr[j] > arr[j + 1]):
            buffer = arr[j]
            arr[j] = arr[j + 1]
            arr[j + 1] = buffer
            swapped = True

    if swapped != True:
        break


print(f'Sorted array: {arr}')
