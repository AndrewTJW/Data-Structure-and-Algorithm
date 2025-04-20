array = [1104, 102, 4104, 315, 50]

#insertion sort
#time complexity = n^2

for i in range (1, len(array)): #always assume the first index of the array is sorted since no element on its left
    for j in range (i - 1, -1, -1): #start at the left of the curr_element until the most left of the index which is 0
        #check if curr_element is smaller than prev_element
        prev_element = array[j]
        curr_element = array[j + 1]
        if (curr_element < prev_element):
            array[j] = curr_element
            array[j + 1] = prev_element
        else:
            break


print(f'Sorted array: {array}')

