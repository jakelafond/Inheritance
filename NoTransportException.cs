using System;

namespace Inheritance
{
    public class NoTransportException : Exception
    {
     public NoTransportException() :base("Oh no you ran into traffic, turning around..."){}

    }
    
}