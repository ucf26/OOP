//
// Created by ucf_26 on 4/24/2025.
//

#include "Engineer.h"


Engineer::Engineer() : Employee(), specialization("Unknown"), over_time_hours(0), over_time_rate(0.0), experience(0) {

}

Engineer::Engineer(string na, int id, double sal, int ex, string sp, int ot_hours, int ot_rate)
    : Employee(na, id, sal), experience(ex), specialization(sp), over_time_hours(ot_hours), over_time_rate(ot_rate) {

}

double Engineer::getTotalSalary() {
    return salary + (over_time_hours * over_time_rate);
}

void Engineer::print() {
    Employee::print();
    cout << ", Experience = " << experience << ", Specialization = " << specialization << ", Over Time Hours = "
         << over_time_hours << ", Over Time Rate = " << over_time_rate << '\n';
}

void Engineer::setExperience(int ex) {
    experience = ex;
}

void Engineer::setSpecialization(string spec) {
    specialization = spec;
}

void Engineer::setOverTimeHours(int ov_h) {
    over_time_hours = ov_h;
}

void Engineer::setOverTimeRate(double ov_r) {
    over_time_rate = ov_r;
}
