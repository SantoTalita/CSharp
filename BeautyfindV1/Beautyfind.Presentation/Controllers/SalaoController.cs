using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeautyfindV1.Service;
using BeautyfindV1.Domain;

namespace Beautyfind.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class SalaoController : Controller
    {
        //SalaoService salaoService = new SalaoService();
        ISalaoService salaoService;

        [HttpGet]
        [Route("/saloes")]
        public IEnumerable<SalaoModel> GetSaloes()
        {
            //validacao
            return salaoService.GetSaloes();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
