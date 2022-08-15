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

    for (int i = 0; i < MAX_SHAPES; i++) {
        delete ptr[i];
    }

}

int main() {
    Shape* a = new Rectangle(2, 4);
    int i = 0;
    //cout << a->GetArea() << endl;  same as below, use * to get value/object at pointer
    cout << a->toString() << endl;
    delete a;

    Rectangle b;
    cout << b.toString() << endl;
    
    // observe data type of c, shape, 
    Shape* c = new Square(3);
    cout << c->toString() << endl;
    delete c;

    Shape* d = new Circle(5);
    cout << d->toString();

    createShapes();

    return 0;
}