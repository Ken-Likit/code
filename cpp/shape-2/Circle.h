#ifndef CIRCLE_H
#define CIRCLE_H
#define _USE_MATH_DEFINES

#include <cmath>
#include <iomanip>
#include <iostream>
#include <sstream>
#include <string>
#include "Shape.h"
using namespace std;

class Circle : public Shape {
    
    public:
        Circle() : Shape() {
            shapeType = ST_Circle;
        }
        Circle(double r) : Shape() {
            radius = r;
            shapeType = ST_Circle;
        }
        ~Circle() {}

        double GetArea() {
            return M_PI * pow(radius, 2); 
        }

        double GetPerimeter() {
            return M_PI * 2 * radius;
        }

        string toString() {
            stringstream rStream, aStream, pStream;
            rStream << fixed << setprecision(2) << radius; 
            aStream << fixed << setprecision(2) << GetArea();
            pStream << fixed << setprecision(2) << GetPerimeter();

            // return "Circle has Radius = " + to_string(radius) + 
            // " Area = " + to_string(GetArea()) +
            // " Perimeter = " + to_string(GetPerimeter()) +
            // "\n";

            return "Circle has Radius = " + rStream.str() + 
            " Area = " + aStream.str() +
            " Perimeter = " + pStream.str() +
            " ShapeType = " + ShapeTypeToString(shapeType) +
            "\n";    
        }  

};
#endif