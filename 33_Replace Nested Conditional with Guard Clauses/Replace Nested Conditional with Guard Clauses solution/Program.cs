using System;
using System.Collections.Generic;
class Employee
{
    bool isDead;
    bool isSeparated;
    bool isRetired;

    public Employee(bool dead, bool separated, bool retired)
    {
        isDead = dead;
        isSeparated = separated;
        isRetired = retired;
    }

    public double GetPayAmount()
    {
        if (isDead)
            return DeadAmount();

        if (isSeparated)
            return SeparatedAmount();

        if (isRetired)
            return RetiredAmount();

        return NormalPayAmount();
    }

    double DeadAmount() => 0;
    double SeparatedAmount() => 1000;
    double RetiredAmount() => 2000;
    double NormalPayAmount() => 3000;
}