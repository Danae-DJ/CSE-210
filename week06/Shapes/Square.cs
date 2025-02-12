using System;
using System.Reflection.Metadata.Ecma335;

class Square
{
    private double _side;

    public Square( double side)
    {
        _side = side;
    }

    public string GetArea()
    {
        return $"{_side * _side}";
    }
}