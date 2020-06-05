using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace JamesScioMVC5.NHibernateSample
{
    public class NHibernateSampleCode
    {
        public void HiberNateSample()
        {
            var cfg = new Configuration();

            /**
             * connection String:
             * Data Source=DESKTOP-8OLF75L;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
             */

            /*
            string DataSource = "DESKTOP-8OLF75L";
            string InitialCatalog = "JamesScio_DB";
            string IntegratedSecurity = "True";
            string ConnectTimeout = "30";
            string Encrypt = "False"; 
            string TrustServerCertificate = "False";
            string ApplicationIntent = "ReadWrite";
            string MultiSubnetFailover = "False";
            */

            cfg.DataBaseIntegration(x =>
                {
                    x.ConnectionString = "Data Source=DESKTOP-8OLF75L;Initial Catalog = JamesScio_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    x.Driver<SqlClientDriver>();
                    x.Dialect<MsSql2012Dialect>();
                });

            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            var sefact = cfg.BuildSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {

                    var emps = session.CreateCriteria<Employee>().List<Employee>();

                    foreach (var emp in emps)
                    {
                        Console.WriteLine("{0} \t{1} \t{2}",
                           emp.ID, emp.Name, emp.Password);
                    }


                    var emp1 = new Employee
                    {
                        ID = 1,
                        Name = "Test1",
                        Position = "TP_1",
                        Password = "123"
                    };

                    var emp2 = new Employee
                    {
                        ID = 2,
                        Name = "Test2",
                        Password = "1234"
                    };

                    //session.Save(emp1);
                    //session.Save(emp2);

                    tx.Commit();
                }
                Console.ReadLine();
            }

        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Password { get; set; }
    }
}