//
// Created by ucf_26 on 4/24/2025.
//

#include "Sales.h"


Sales::Sales() : Employee(), commission_rate(0), gross_sales(0) {

}

Sales::Sales(string na, int id, double sal, int gs, double cr) : Employee(na, id, sal), gross_sales(gs),
                                                                 commission_rate(cr) {

}

double Sales::getTotalSalary() {
    return salary + (commission_rate * gross_sales);
}


void Sales::print() {
    Employee::print();
    cout << ", Commission Rate = " << commission_rate << ", Gross Salary = " << gross_sales << '\n';
}


void Sales::setGrossSales(int gs) {
    gross_sales = gs;
}

void Sales::setCommissionRate(double cr) {
    commission_rate = cr;
}