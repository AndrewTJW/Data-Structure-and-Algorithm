#include <iostream>

using namespace std;

class CircularQueue {
private:
    int *arr; //ptr to point to initialized array
    int front, size;
    int capacity;

public:
    CircularQueue(int arg_maxcap) {
        arr = new int[arg_maxcap];
        capacity = arg_maxcap;
        front = 0;
        size = 0;
    }

    int Enqueue(int arg_addelement) {
        if (size == capacity) {
            cout << "Queue is full!" << endl;
            return 1;
        } else {
            int rear = (front + size) % capacity; //important to regulate the circulation
            arr[rear] = arg_addelement;
            cout << "Elemenet added: " << arg_addelement << endl;
            size ++;
            return 0;
        }
    }

    int Dequeue() {
        if (size == 0) {
            cout << "Queue is underflow" << endl;
            return 1;
        } else {
            cout << "Element removed: " << arr[front] << endl;
            front = (front + 1) % capacity; //important to regulate the circulation
            size --;
            return 0;
        }
    }

};



int main () {
    CircularQueue cq1(5); //instantiate new circular queue object
    cq1.Enqueue(10);
    cq1.Enqueue(20);
    cq1.Dequeue();
    cq1.Dequeue();
    cq1.Enqueue(30);
    cq1.Enqueue(40);
    cq1.Enqueue(50);
    cq1.Dequeue();
    cq1.Dequeue();
    cq1.Dequeue();


}