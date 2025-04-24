//
// Created by ucf_26 on 4/24/2025.
//

#ifndef OOP_1_ENGINEER_H
#define OOP_1_ENGINEER_H

#include "Employee.h"

class Engineer : public Employee{
private:
    int experience;
    string specialization;
    int over_time_hours;
    double over_time_rate;
public:
    Engineer();
    Engineer(string na, int id, double sal, int ex, string sp, int ot_hours, int ot_rate);
    double getTotalSalary();
    void print();
    void setExperience(int ex);
    void setSpecialization(string spec);
    void setOverTimeHours(int ov_h);
    void setOverTimeRate(double ov_r);
};


#endif //OOP_1_ENGINEER_H
