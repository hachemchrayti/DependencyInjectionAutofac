using System;
using DICourseDemo;

namespace DIModularityDemo
{

    //Data Access layer
    public class SqlServerDal : IDal
    {
        public void Add()
        {
            Console.WriteLine("Sqlserver inserted");
        }
    }
}
