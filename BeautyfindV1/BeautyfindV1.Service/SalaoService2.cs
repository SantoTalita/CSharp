using BeautyfindV1.Domain;
using BeautyfindV1.Repository.Implementations;
using System;
using System.Collections.Generic;

namespace BeautyfindV1.Service
{
    public class SalaoService2 : ISalaoService
    {
        SalaoRepository repository;

        public SalaoService2(SalaoRepository repository)
        {
            this.repository = repository;
        }

        public SalaoService2()
        {
            this.repository = new SalaoRepository();
        }

        public List<SalaoModel> GetSaloes()
        {
            //logica
            return new List<SalaoModel>() { new SalaoModel() { Nome = "Outro" }  };
        }
    }
}