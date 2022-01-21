using System;

namespace ConsoleApp16
{
    internal class NorthwindContext : IDisposable
    {
        public object Customers { get; internal set; }
    }
}