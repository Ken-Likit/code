#include <iostream>
using namespace std;

class Shape {

    private:
        double length;
        double height;
        double radius;
        double area;
        double perimeter;

    public:

        Shape();
        Shape(double l, double h);

        double GetLength();
        double GetHeight();
        double GetRadius();
        double GetArea();
        double GetPerimeter();
/*
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

        double GetArea() {
            area = length * height;
            return area;
        }

        double GetPerimeter() {
            perimeter = (2 * length) + (2 * height);
            return perimeter;
        }
*/
};

Shape::Shape() {
    length = 0;
    height = 0;
    radius = 0;
    area = 0;
    perimeter = 0;
}

Shape::Shape(double l, double h) {
    length = l;
    height = h;
    radius = 0;
    area = 0;
    perimeter = 0; 
}

double Shape::GetLength() {
    return length;
}

double Shape::GetHeight() {
    return height;
}

double Shape::GetRadius() {
    return radius;
}

double Shape::GetArea() {
    area = length * height;
    return area;
}

double Shape::GetPerimeter() {
    perimeter = (2 * length) + (2 * height);
    return perimeter;
}
