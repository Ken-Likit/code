#include "main.h"

using namespace std;

int main() {
    
    Shape* a = new Rectangle(2, 4);
    int i = 0;
    cout << a->GetArea() << endl;
    cout << a->GetPerimeter() << endl;

    Rectangle b;
    cout << b.GetArea() << endl;
    cout << b.GetPerimeter() << endl;
    
    //observe data type of c, shape, 
    Shape* c = new Square(3);
    cout << c->GetArea() << endl;
    cout << c->GetPerimeter() << endl; 

    return 0;
}