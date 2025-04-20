def mergeSort(arr):
    if len(arr) == 1: #base case, when left with array with length 1, stop the current call stack
        return arr

    mid = len(arr) // 2 #halve the array as long as it is not left with 1 piece of array block yet
    leftHalf = arr[:mid] #from 0 - middle not included
    rightHalf = arr[mid:] #from middle to end not included

    sortedLeft = mergeSort(leftHalf) #keep calling merge sort until it returns and arr
    sortedRight = mergeSort(rightHalf)

    return merge(sortedLeft, sortedRight) # will be called when there is only 1 block of array left on left side and right side, place them into merge func

def merge(left, right): #take the 2 pieces of left and right and compare
    result = [] #the end result
    i = j = 0 #left and right start from 0 

    while i < len(left) and j < len(right): #loop until the of block for each of the part, which is left and right
        if left[i] < right[j]: #if left block is smaller than right block, add it into array
            result.append(left[i])
            i += 1 
        else: #if left is bigger than right
            result.append(right[j]) #add right into the result first
            j += 1

    result.extend(left[i:]) #since we exit the loop, means there is no more left that we need to sort, therefore we extend the array
    result.extend(right[j:]) #""

    return result

unsortedArr = [10, 12, 14, 21, 8, 12, 16, 26, 25]
sortedArr = mergeSort(unsortedArr)
print("Sorted array:", sortedArr)