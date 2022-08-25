#ifndef RECTANGLE_H
#define RECTANGLE_H 

#include <iostream>
#include <string>
#include "Shape.h"
using namespace std;

class Rectangle : public Shape {

    public:
        Rectangle() : Shape() {
            shapeType = ST_Rectangle;
        };
        Rectangle(double l, double h) : Shape(l, h) {
            shapeType = ST_Rectangle;
        };
        ~Rectangle() {
            //cout << "Rectangle destructor" << endl;
        }

        double GetArea() {
            return (height * length);
        }
        double GetPerimeter() {
            return ((2 * height) + (2 * length)); 
        }
        void SetHeight(double h) {
            height = h;
        }
        void SetLength(double l) {
            length = l;
        }

        string toString() {
            return "Rectangle has Height = " + to_string(height) + 
            " Length = " + to_string(length) +
            " Area = " + to_string(GetArea()) +
            " Perimeter = " + to_string(GetPerimeter()) +
            "\n";
        }
};
#endif