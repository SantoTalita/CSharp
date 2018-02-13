using Beautyfind.Presentation.Controllers;
using BeautyfindV1.Domain;
using BeautyfindV1.Service;
using System;
using System.Collections.Generic;

namespace BeautyfindV1.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //var test = new SalaoIntegrationTest();
            var test = new SalaoUnitTest();
            test.GetSaloesTest();
            Console.ReadLine();
        }

        public class SalaoIntegrationTest
        {
            public void GetSaloesTest()
            {
                var salaoControler = new SalaoController();

                IEnumerable<SalaoModel> saloes = salaoControler.GetSaloes();

                Console.WriteLine(((List<SalaoModel>)saloes)[0].Nome);
            }
        }

        public class SalaoUnitTest
        {
            public void GetSaloesTest()
            {
                var salaoControler = new SalaoController();

                IEnumerable<SalaoModel> saloes = salaoControler.GetSaloes();

                Console.WriteLine(((List<SalaoModel>)saloes)[0].Nome);
            }
        }

        public class SalaoServiceMock : ISalaoService
        {
            public List<SalaoModel> GetSaloes()
            {
                var x = new List<SalaoModel>();
                x.Add(new SalaoModel() { Nome = "Mock Salao" });
                return x;
            }
        }
    }
}