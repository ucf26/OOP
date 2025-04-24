//
// Created by ucf_26 on 4/24/2025.
//

#ifndef OOP_CONCEPTS_EMPLOYEE_H
#define OOP_CONCEPTS_EMPLOYEE_H

#include <iostream>
#include <string>
using namespace std;

class Employee {
protected:
    string name;
    int employee_id;
    double salary;
public:
    Employee();
    Employee(string na, int id, double sal);
    virtual void print();
    virtual double getTotalSalary() = 0;
};


#endif //OOP_CONCEPTS_EMPLOYEE_H
