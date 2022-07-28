#include <iostream>
using namespace std;
//abstract base class
//no implementation
class Shape {

    protected:
        double length;
        double height;
        double radius;
        double area;
        double perimeter;

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

        double GetLength() {
            return length;
        } 
        double GetHeight() {
            return height;
        }
        double GetRadius() {
            return radius;
        }
        virtual double GetArea() = 0;//pure virtual function means = to 0
        virtual double GetPerimeter() = 0;
    //virtual + ... + = 0 means abstract
};