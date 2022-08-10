#include <iostream>
#include <string>
#include "Shape.h"
using namespace std;

class Rectangle : public Shape {

    public:
        Rectangle() : Shape() {};
        Rectangle(double l, double h) : Shape(l, h) {};
        ~Rectangle() {
            //cout << "Rectangle destructor" << endl;
        }

        double GetArea() {
            return (height * length);
        }
        double GetPerimeter() {
            return ((2 * height) + (2 * length)); 
        }

        string toString() {
            return "Rectangle has Height = " + to_string(height) + " Length = " + to_string(length) +"\n";
        }
};

