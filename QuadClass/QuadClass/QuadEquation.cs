using System;

class QuadEquation
{
    //Properties

    private double _theATerm = 0;
    private double _theBTerm = 0;
    private double _theCTerm = 0;

    //get, set accessors

    public double TermA
    {
        get { return _theATerm; }
        set { _theATerm = value; }
    }

    public double TermB
    {
        get { return _theBTerm; }
        set { _theBTerm = value; }
    }

    public double TermC
    {
        get { return _theCTerm; }
        set { _theCTerm = value; }
    }

    //Methods

    public string PrintFormula()
    {
        string formula;

        //Construct Term A for the formula
        if (Math.Abs(_theATerm) == 1)
        {
            if (_theATerm == -1)
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
            formula = _theATerm + "x\u00B2 ";
        }

        //Construct Term B for the formula
        if (Math.Abs(_theBTerm) == 1)
        {
            if (_theBTerm == -1)
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
            if (_theBTerm < 0)
            {
                formula += "- " + Math.Abs(_theBTerm) + "x "; //formula += is equal to formula = formula +
            }
            else
            {
                formula += "+ " + _theBTerm + "x ";
            }
        }

        //Construct Term C for the formula
        if (_theCTerm > 0)
        {
            formula = formula + "+ " + _theCTerm;
        }
        else
        {
            formula = formula + "- " + Math.Abs(_theCTerm);
        }

        return formula;

    }

    private double CalcDiscriminant()
    {
        return Math.Pow(_theBTerm, 2) - 4 * _theATerm * _theCTerm;
    }

    public string CalcXSub()
    {
        double discriminant = CalcDiscriminant();
        double twoTermA = 2 * _theATerm;
        double xSol;

        if (discriminant >= 0)
        {
            xSol = (-_theBTerm - Math.Sqrt(discriminant)) / twoTermA;
            return xSol.ToString("F3");
        }
        else
        {
            return (-_theBTerm / twoTermA).ToString("F3") + " - " + (Math.Sqrt(Math.Abs(discriminant)) / twoTermA).ToString("F3");
        }
    }

    public string CalcXAdd()
    {
        double discriminant = CalcDiscriminant();
        double twoTermA = 2 * _theATerm;
        double xSol;

        if (discriminant >= 0)
        {
            xSol = (-_theBTerm + Math.Sqrt(discriminant)) / twoTermA;
            return xSol.ToString("F3");
        }
        else
        {
            return (-_theBTerm / twoTermA).ToString("F3") + " + " + (Math.Sqrt(Math.Abs(discriminant)) / twoTermA).ToString("F3");
        }
    }
}