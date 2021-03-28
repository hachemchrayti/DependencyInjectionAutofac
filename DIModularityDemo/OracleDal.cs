using System;
using DICourseDemo;

namespace DIModularityDemo
{
    public class OracleDal : IDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle inserted");
        }
    }
}
