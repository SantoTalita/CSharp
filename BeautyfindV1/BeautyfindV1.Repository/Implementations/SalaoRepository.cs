using BeautyfindV1.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyfindV1.Repository.Implementations
{
    public class SalaoRepository
    {
        public List<SalaoModel> GetSaloes()
        {
            return new List<SalaoModel>() { new SalaoModel() { Nome = "SELECT * FROM SALAO" } };
        }
    }
}
