using System;

namespace calculatrice;

public class Calculatrice
{
    private int firstNbr;
    private int secondNbr;

    public Calculatrice (int _firstNbr, int _secondNbr){
        this.firstNbr = _firstNbr;
        this.firstNbr = _secondNbr;
    }
    public int getFirstNbr() { return firstNbr;}
    public int getSecondNbr() { return secondNbr;}
    public void setFirstNbr(int _firstNbr ) { firstNbr = _firstNbr; }
    public void setSecondNbr(int _secondNbr ) { secondNbr = _secondNbr; }

    public int Addition(int _firstNbr, int _secondNbr) { 
        return _firstNbr + _secondNbr;
    }

    public int Soustraction(int _firstNbr, int _secondNbr) { 
        return _firstNbr - _secondNbr;
    }
    public int Multiplication(int _firstNbr, int _secondNbr) { 
        return _firstNbr * _secondNbr;
    }

    public int Division(int _firstNbr, int _secondNbr) { 
        return _firstNbr / _secondNbr;
    }
    public int Modulo(int _firstNbr, int _secondNbr) { 
        return _firstNbr % _secondNbr;
    }


}
