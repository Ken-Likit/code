#ifndef MYSINGLETON_H
#define MYSINGLETON_H

#include <iostream>
#include <string>
using namespace std;

class MySingleton {
    public:
        static MySingleton* getInstance();
        int getValue() {
            return _value;
        }
        void setValue(int x) {
            _value = x;
        } 

    protected:
        int _value;

    private:
        static MySingleton* _instance;
        
        //constructors
        //MySingleton() : _value(0) {};  either way is the same

        MySingleton() { _value = 0; };

        MySingleton(const MySingleton&); //copy constructor

        MySingleton& operator=(const MySingleton&);
};
MySingleton* MySingleton::_instance = NULL;

MySingleton* MySingleton::getInstance() {
    if (_instance == NULL) {
        _instance = new MySingleton();
    }
    return _instance;
}
#endif