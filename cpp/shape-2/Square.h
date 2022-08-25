#ifndef SQUARE_H
#define SQUARE_H

#include <iostream>
#include <string>
#include "Rectangle.h"
using namespace std;

class Square : public Rectangle {

    public:
        Square() : Rectangle() {
            shapeType = ST_Square;
        };
        Square(double l) : Rectangle(l, l) {
            shapeType = ST_Square;
        };
        ~Square() {
            //cout << "Square destructor" << endl;
        }

        double GetArea() {
            return (height * length);
        }

        double GetPerimeter() {
            return ((2 * height) + (2 * length)); 
        }

        
        string toString() {
            return "Square has side = " + 
            to_string(height) +
            " Area = " + to_string(GetArea()) +
            " Perimeter = " + to_string(GetPerimeter()) +
            //" Shapetype = " + shapeType +
            "\n";
        }
};
#endif