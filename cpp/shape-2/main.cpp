#include "main.h"

using namespace std;

const int MAX_SHAPES = 4;

void createShapes() {
    Shape* ptr[MAX_SHAPES];

    for (int i = 0; i < MAX_SHAPES; i++) {
        if (i % 2 == 0) {
            ptr[i] = new Square(i + 2);
        } 
        else {
            ptr[i] = new Rectangle(i+1, i+2);
        }
    }

    for (int i = 0; i < MAX_SHAPES; i++) {
        cout << ptr[i]->toString();
    }

    delete[] ptr;
}

int main() {
    Shape* a = new Rectangle(2, 4);
    int i = 0;
    //cout << a->GetArea() << endl;  same as below, use * to get value/object at pointer
    cout << (*a).GetArea() << endl;
    cout << a->GetPerimeter() << endl;
    delete a;

    Rectangle b;
    cout << b.GetArea() << endl;
    cout << b.GetPerimeter() << endl;

    Square d;

    
    // observe data type of c, shape, 
    Shape* c = new Square(3);
    cout << c->GetArea() << endl;
    cout << c->GetPerimeter() << endl; 
    delete c;

    createShapes();

    return 0;
}