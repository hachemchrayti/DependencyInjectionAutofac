using System;
using System.Reflection.Metadata;
using Autofac;
using DICourseDemo;
using Unity;

namespace DIModularityDemo
{
    //UI Layer
    class Program
    {


        static void Main(string[] args)
        {

            //Using Unity
            //IUnityContainer unityContainer = new UnityContainer();
            //unityContainer.RegisterType<Customer>();
            //unityContainer.RegisterType<IDal, SqlServerDal>();
            //unityContainer.RegisterType<IDal, OracleDal>();
            //Customer obj = unityContainer.Resolve<Customer>(); //new Customer(new OracleDal());



            //Using autofac
            var BuildContainer = new ContainerBuilder();
            BuildContainer.RegisterType<SqlServerDal>().As<IDal>();
            BuildContainer.RegisterType<SqlServerDal>().As<IDal>();
            BuildContainer.RegisterType<Customer>().AsSelf();
            var container = BuildContainer.Build();

            var sql = container.Resolve<IDal>();

            Customer obj = container.Resolve<Customer>();
            obj.customerName = "Hachem";
            obj.Add();


        }
    }
}
