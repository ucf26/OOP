//
// Created by ucf_26 on 4/24/2025.
//

#include "Employee.h"


Employee::Employee() : name("Unknown"), employee_id(0), salary(0) {

}

Employee::Employee(string na, int id, double sal) : name(na), employee_id(id), salary(sal) {

}

void Employee::print() {
    cout << "Name = " << name << ", Employee ID = " << employee_id << ", Salary = " << salary;
}