//
// Created by ucf_26 on 4/24/2025.
//

#ifndef OOP_1_SALES_H

#define OOP_1_SALES_H

#include "Employee.h"


class Sales : public Employee {
private:
    int gross_sales;
    double commission_rate;
public:
    Sales();
    Sales(string na, int id, double sal, int gs, double cr);
    double getTotalSalary();
    void print();
    void setGrossSales(int gs);
    void setCommissionRate(double cr);
};


#endif //OOP_1_SALES_H
