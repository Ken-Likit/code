#include "main.h"

using namespace std;

const int MAX_SHAPES = 20;
Shape *shapePtrArr[MAX_SHAPES];

void testOne() 
{
    cout << "\ntest 1\n";

    Shape *a = new Rectangle(2, 4);
    int i = 0;
    // cout << a->GetArea() << endl;  same as below, use * to get value/object at pointer
    cout << a->toString() << endl;
    delete a;

    Rectangle b;
    cout << b.toString() << endl;

    // observe data type of c, shape,
    Shape *c = new Square(3);
    cout << c->toString() << endl;
    delete c;

    Shape *d = new Circle(5);
    cout << d->toString();
}

void createShapes() 
{
    cout << "\nCreate Shapes\n";

    for (int i = 0; i < MAX_SHAPES; i++)
    {
        if (i % 3 == 0)
        {
            shapePtrArr[i] = new Circle(i+4);
        }
        else if (i % 2 == 0) 
        {
            shapePtrArr[i] = new Square(i + 2);
        }
        else
        {
            shapePtrArr[i] = new Rectangle(i + 1, i + 2);
        }
    }

    for (int i = 0; i < MAX_SHAPES; i++)
    {
        cout << shapePtrArr[i]->toString();
    }
}

void testPointer() 
{
    cout << "\nTest Pointer \n";

    Rectangle rect(3, 5);
    cout << rect.toString();

    Rectangle *ptrRect = &rect;
    cout << ptrRect->toString();
    ptrRect->SetHeight(10);
    cout << "Setting Height to 10 \n";
    cout << rect.toString();
    cout << ptrRect->toString();
}

void dynamicCast() 
{
    cout << "\nDynamic Cast\n";
    cout << "Count number of Each Shape\n";
    int circleCounter = 0;
    int squareCounter = 0;
    int rectCounter = 0;
    for (int i = 0; i < MAX_SHAPES; i++) {
        Shape* ptr = shapePtrArr[i];
        Circle* cPtr = dynamic_cast<Circle*>(ptr);
        if (cPtr != nullptr) {
            circleCounter++;
        }
        else {
            Square* sPtr = dynamic_cast<Square*>(ptr);
            if (sPtr != nullptr) {
                squareCounter++;
            }
            else {
                Rectangle* rPtr = dynamic_cast<Rectangle*>(ptr);
                if (rPtr != nullptr) {
                    rectCounter++;
                }
            }
        }
    }
    cout << "Total Number of Circles = " << circleCounter << endl;
    cout << "Total Number of Squares = " << squareCounter << endl;
    cout << "Total Number of Rectangles = " << rectCounter << endl;
}

void ptrClean() {
    for (int i = 0; i < MAX_SHAPES; i++)
    {
        delete shapePtrArr[i];
    } 
}

void testSingleton() {
    MySingleton* mySingle = MySingleton::getInstance();
    mySingle->setValue(5);
    cout << to_string(mySingle->getValue()) << endl;
    MySingleton* mySingle2 = MySingleton::getInstance();
    cout << to_string(mySingle2->getValue()) << endl;
}

int main()
{
    testOne();

    createShapes();

    testPointer();

    dynamicCast();

    ptrClean();

    testSingleton();

    return 0;
}