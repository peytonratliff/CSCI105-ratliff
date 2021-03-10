using System;

class Equation
{
    //Properties

    public double TermA { get; set; } = 0;
    public double TermB { get; set; } = 0;
    public double TermC { get; set; } = 0;

    //Constructors

    public Equation() { } //Default constructor - empty instance of the object
    
    public Equation(double termA, double termB, double termC)
    {
        TermA = termA;
        TermB = termB;
        TermC = termC;
    }
    
    //Methods

    public string PrintFormula()
    {
        string formula;

        //Construct Term A for the formula
        if (Math.Abs(TermA) == 1)
        {
            if (TermA == -1)
            {
                formula = "-x\u00B2 ";
            }
            else
            {
                formula = "x\u00B2";
            }
        }
        else
        {
            formula = TermA + "x\u00B2 ";
        }

        //Construct Term B for the formula
        if (Math.Abs(TermB) == 1)
        {
            if (TermB == -1)
            {
                formula = formula + "- x ";
            }
            else
            {
                formula = formula + "+ x ";
            }
        }
        else
        {
            if (TermB < 0)
            {
                formula += "- " + Math.Abs(TermB) + "x "; //formula += is equal to formula = formula +
            }
            else
            {
                formula += "+ " + TermB + "x ";
            }
        }

        //Construct Term C for the formula
        if (TermC > 0)
        {
            formula = formula + "+ " + TermC;
        }
        else
        {
            formula = formula + "- " + Math.Abs(TermC);
        }

        return formula;

    }

    private double CalcDiscriminant()
    {
        return Math.Pow(TermB, 2) - 4 * TermA * TermC;
    }

    public string CalcXSub()
    {
        double discriminant = CalcDiscriminant();
        double twoTermA = 2 * TermA;
        double xSol;

        if (discriminant >= 0)
        {
            xSol = (-TermB - Math.Sqrt(discriminant)) / twoTermA;
            return xSol.ToString("F3");
        }
        else
        {
            return (-TermB / twoTermA).ToString("F3") + " - " + (Math.Sqrt(Math.Abs(discriminant)) / twoTermA).ToString("F3");
        }
    }

    public string CalcXAdd()
    {
        double discriminant = CalcDiscriminant();
        double twoTermA = 2 * TermA;
        double xSol;

        if (discriminant >= 0)
        {
            xSol = (-TermB + Math.Sqrt(discriminant)) / twoTermA;
            return xSol.ToString("F3");
        }
        else
        {
            return (-TermB / twoTermA).ToString("F3") + " + " + (Math.Sqrt(Math.Abs(discriminant)) / twoTermA).ToString("F3");
        }
    }
}