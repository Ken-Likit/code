
#include <iostream>
#include "Shape.h"
using namespace std;

class Rectangle : public Shape {

    public:
        Rectangle() : Shape() {};
        Rectangle(double l, double h) : Shape(l, h) {};

        double GetArea() {
            return (height * length);
        }
        double GetPerimeter() {
            return ((2 * height) + (2 * length)); 
        }
};

