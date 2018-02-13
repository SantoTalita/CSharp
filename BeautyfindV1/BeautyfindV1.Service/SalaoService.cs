using BeautyfindV1.Domain;
using BeautyfindV1.Repository.Implementations;
using System;
using System.Collections.Generic;

namespace BeautyfindV1.Service
{
    public class SalaoService : ISalaoService
    {
        SalaoRepository repository;

        public SalaoService(SalaoRepository repository)
        {
            this.repository = repository;
        }

        public SalaoService()
        {
            this.repository = new SalaoRepository();
        }

        public List<SalaoModel> GetSaloes()
        {
            //logica
            return repository.GetSaloes();
        }
    }
}
