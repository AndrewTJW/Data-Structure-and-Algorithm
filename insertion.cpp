#include <iostream>
using namespace std;

//function for insertion sorting process

void insertionSort(int unsorted_arr[], int a_length_of_array) {
    for (int i = 1; i < a_length_of_array; i++) {
        int key = unsorted_arr[i];
        int j = i - 1;
        while (j >= 0 && unsorted_arr[j] > key) {
            unsorted_arr[j+1] = unsorted_arr[j];
            j = j - 1;
        }
        unsorted_arr[j + 1] = key;
    }
}

void printArray(int sorted_array[], int a_length_of_array) {
    for (int i = 0; i < a_length_of_array; i++) {
        cout << sorted_array[i] << " ";
        cout << endl;
    }
}


int main () {
                //{ 92, 111, 145, 145} 
    int arr[] = {11, 13, 10, 89, 56, 109, 145};

    /*
    finding the size of array - arr[] has 7 elements, 
    each of them are storing int, int is 4 bytes, therefore arr[] 
    has 28 bytes. After that, we take any one of the element stored in array and calc
    its space required to store one element, in this case 4 bytes cause its an int
    so (7 * 4) / 4 = 7. integer 7 is stored in size_of_array. 
    */
    int size_of_array = sizeof(arr) / sizeof(arr[0]);
    insertionSort(arr, size_of_array);
    printArray(arr, size_of_array);

    return 0;
}