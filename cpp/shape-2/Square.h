#include <iostream>
#include "Rectangle.h"
using namespace std;

class Square : public Rectangle {

    public:
        Square() : Rectangle() {};
        Square(double l) : Rectangle(l, l) {};

        double GetArea() {
            return (height * length);
        }
        double GetPerimeter() {
            return ((2 * height) + (2 * length)); 
        }
};