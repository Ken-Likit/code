#ifndef SHAPE_H
#define SHAPE_H

#include <iostream>
#include <string>
using namespace std;
//abstract base class
//no implementation
enum ShapeType {
    ST_Unknown = 0,
    ST_Rectangle = 1, 
    ST_Square = 2, 
    ST_Circle = 3
};
constexpr const char* ShapeTypeToString(ShapeType e) throw()
{
    switch (e)
    {
        case ShapeType::ST_Unknown: return "ST_Unknown";
        case ShapeType::ST_Rectangle: return "ST_Rectangle";
        case ShapeType::ST_Square: return "ST_Square";
        case ShapeType::ST_Circle: return "ST_Circle";
        default: throw std::invalid_argument("Unimplemented item");
    }
}

class Shape {

    protected:
        double length;
        double height;
        double radius;
        double area;
        double perimeter;
        ShapeType shapeType = ST_Unknown;

    public:
        Shape() {
            length = 0;
            height = 0;
            radius = 0;
            area = 0;
            perimeter = 0;
        }
        Shape(double l, double h) {
            length = l;
            height = h;
            radius = 0;
            area = 0;
            perimeter = 0;            
        }

        ~Shape() {
            //cout << "Shape destructor" << endl;
        }

        double GetLength() {
            return length;
        } 

        double GetHeight() {
            return height;
        }

        double GetRadius() {
            return radius;
        }
        //Must impliment in derived classes
        virtual double GetArea() = 0;//pure virtual function means = to 0
        virtual double GetPerimeter() = 0;
        //default tostring but can be overridden with new function
        virtual string toString() {
            return "Shape has Height = " + to_string(height) + " Length = " + to_string(length) +"\n";
        }
        //virtual + ... + = 0 means abstract
        static void BuildShapes() {
            cout << "BuildShapes" << endl;
        } 
};

#endif