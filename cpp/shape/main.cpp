#include <iostream>
#include "Shape.h"

using namespace std;

int main() {
    
    Shape* a = new Shape(2, 4);
    int i = 0;
    cout << a->GetArea() << endl;
    cout << a->GetPerimeter();
    Shape b;
    cout << b.GetArea() << endl;
    cout << b.GetPerimeter();
    return 0;
}