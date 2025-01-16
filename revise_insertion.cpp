// revising insertion sort 

// get size of array, and create an unsorted array for processing

// a primary key that takes the value of second element of the array

// a phantom key that always points at the element to the left of element primary key is pointing at

// compare right with left element of the array 

// check which bigger and replace the value that is bigger on the right

// set element value of secondary key that is pointing at to the primary key value

#include <iostream>
using namespace std;

void InsertionSort (int arr[], int size_of_array) {
    for (int i = 1; i < size_of_array; i++) {
        int primary_key = arr[i];
        int phantom_key = i - 1;

        while (phantom_key >= 0 && arr[phantom_key] > primary_key) {
            arr[phantom_key + 1] = arr[phantom_key];
            phantom_key = phantom_key - 1;
        }
        arr[phantom_key + 1] = primary_key;
    }
}

void displaySortedArray(int sortedarray[], int a_size_of_array) {
    for (int i = 0; i < a_size_of_array; i++) {
        cout << sortedarray[i] << endl;
    }
}

int main () {
    int arr[] = {45, 64, 34, 17, 18, 18, 100, 145, 101, 97};
    int size_of_array = sizeof(arr) / sizeof(arr[0]); 

    InsertionSort(arr, size_of_array);

    displaySortedArray(arr, size_of_array);
}