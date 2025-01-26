#include <iostream>

using namespace std;

struct Node {
    string data;
    Node *next;
    Node *prev;
};

//add nodes dynamically through user input
void addNodes(Node *arg_ptr) {
    int node_count = 1;
    char ans;
    cout << "Enter the data for the header node: ";
    cin >> arg_ptr->data;
    arg_ptr->prev = NULL;
    node_count += 1;

    while (arg_ptr != NULL) {
        cout << "Add nodes? (y/n): ";
        cin >> ans;
        if (ans == 'y') {
            arg_ptr->next = new Node;
            arg_ptr->next->prev = arg_ptr;
            arg_ptr = arg_ptr->next;
            cout << "Data(string) for node " << node_count << ": ";
            cin >> arg_ptr->data;
            node_count += 1;
        } else {
            arg_ptr->next = NULL;
            arg_ptr = arg_ptr->next;
        }
    }
}

//tranverse through nodes and display their value
void displayAllNodes(Node *arg_ptr) {
    int node_track = 1;

    while (arg_ptr != NULL) {
        cout << "Data in node " << node_track << ": " << arg_ptr->data;
        cout << endl;
        arg_ptr = arg_ptr->next;
        node_track += 1;
    }
}

//reverse traversal of nodes and printing them out
void displayReversalNodes(Node *arg_ptr) { //here got problem segmentation fault
    cout << "before operations" << endl;
    Node *phantom_ptr;


    cout << "entering first loop" << endl;
    while (arg_ptr->next != NULL) {
        arg_ptr = arg_ptr->next;
    }
    phantom_ptr = arg_ptr;

    cout << "Entered arg_ptr pre null space!" << endl;
    cout << "Printing nodes in reverse mode!" << endl;
    while (phantom_ptr != NULL) 
    {
        cout << phantom_ptr->data << endl;
        phantom_ptr = phantom_ptr->prev; 
    }
}



int main () {
    //create head and navigator node
    Node *head, *navigator;

    //create the first node and point header to it
    head = new Node;
    //always point navigator to the first node
    navigator = head;
    addNodes(navigator);

    //reset navigator
    navigator = head;
    displayAllNodes(navigator);
    cout << "done printing" << endl;

    //reset navigator
    cout << "reseting navigator" << endl;
    navigator = head;
    displayReversalNodes(navigator);


    //get size of node


    return 0;
}