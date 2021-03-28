using System;
using DICourseDemo;

namespace DIModularityDemo
{
    //Middle Layer
    public class Customer
    {
        public string customerName { get; set; }

        private IDal Odal;

        public Customer(IDal idal)
        {
            Odal = idal;

        }

        //SqlServerDal Odal = new SqlServerDal();
        //OracleDal OracleDal = new OracleDal();

        public void Add()
        {

            Odal.Add();


        }



    }
}
