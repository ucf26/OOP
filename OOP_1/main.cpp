#include <iostream>
#include <vector>
#include "Employee.h"
#include "Engineer.h"
#include "Sales.h"

using namespace std;

int main() {
    vector<Employee*> employees;

    // Add employees to the list
    employees.push_back(new Engineer("Charlie", 103, 6000, 8, "AI", 5, 75));
    employees.push_back(new Sales("Diana", 104, 3500, 80000, 0.12));

    // Process all employees
    for (Employee* emp : employees) {
        emp->print();
        cout << "Total Salary: $" << emp->getTotalSalary() << "\n\n";
    }

    // Cleanup
    for (Employee* emp : employees) delete emp;
    return 0;
}
