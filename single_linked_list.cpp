#include <iostream>

using namespace std; 

struct Node {
    int data;
    Node *next;
};

//function to add new node dynamically[
void AddNewNode (Node *ptr) { //navigator now becomes ptr, function accepts a pointer that points to type [node] 
    char ch = 'y';

    while (ptr != NULL) { //always need to set a condition to check whether navigator is pointing to nothing.
        cout << "Enter data(integer) for current node: ";
        cin >> ptr->data;
        cout << "Continue (y/n)?";
        cin >> ch;
        if (ch == 'y') {
            ptr->next = new Node; //navigator enters current node to access it's [next] value and assign the next pointer to point at new node
            ptr = ptr->next; //navigator pointer now points at the next node.
        }
        else { //if user decides to end the node
            ptr->next = NULL; //pointer enter the current node's next pointer, and make it point to NULL
            ptr = NULL; //navigator now points at nothing since node already ended (optional)
        }
    }
}

void LinkedListTraversal (Node *ptr) { //navigator is passed into this function to demonstrate traversal.
    int counter = 1;

    while (ptr != NULL) {
        cout << "Data in node " << counter << " = " << ptr->data << endl;
        ptr = ptr->next;
        counter += 1;
    }
}


int main () {
    Node *header, *navigator; //compulsory to have if you want to create a dynamic linked list, 
                              //header pointer always points to the first node, navigator pointer is use to navigate across the linked list

    //create the first node
    header = new Node;
    //always point navigator/traversal to the first node which is now header
    navigator = header;
    AddNewNode(navigator);

    navigator = header; //reset navigator to point back at start of node
    LinkedListTraversal(navigator);
    return 0;
}