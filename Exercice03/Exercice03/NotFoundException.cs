using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice03;

public class NotFoundException : Exception
{

    public NotFoundException(string message) : base(message) { }

}
