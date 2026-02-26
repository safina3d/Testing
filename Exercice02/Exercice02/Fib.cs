using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice02;

public class Fib
{
    private int _range;

    public Fib()
    {
    }

    public Fib(int r)
    {
        _range = r;
    }

    //public List<int> GetFibSeries()
    //{
    //    List<int> result = new List<int>();
    //    int a = 0, b = 1, c = 0;
    //    if (_range == 1)
    //    {
    //        result.Add(0);
    //        return result;
    //    }
    //    result.Add(0);
    //    result.Add(1);
    //    for (int i = 2; i < _range; i++)
    //    {
    //        c = a + b;
    //        result.Add(c);
    //        a = b;
    //        b = c;
    //    }
    //    return result;
    //}


    public List<int> GetFibSeries()
    {
        if (_range == 1) return new List<int> { 0 };
        if (_range == 2) return new List<int> { 0, 1 };
        _range--;
        var result = GetFibSeries();
        int count = result.Count;
        result.Add(result[count - 1] + result[count - 2]);
        return result;
    }



}
