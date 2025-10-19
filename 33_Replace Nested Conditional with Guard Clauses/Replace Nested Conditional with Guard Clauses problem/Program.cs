using System;
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
        double result;
        if (isDead)
        {
            result = DeadAmount();
        }
        else
        {
            if (isSeparated)
            {
                result = SeparatedAmount();
            }
            else
            {
                if (isRetired)
                {
                    result = RetiredAmount();
                }
                else
                {
                    result = NormalPayAmount();
                }
            }
        }
        return result;
    }

    double DeadAmount() => 0;
    double SeparatedAmount() => 1000;
    double RetiredAmount() => 2000;
    double NormalPayAmount() => 3000;
}
