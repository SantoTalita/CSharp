using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BeautyfindV1.Repository.Interfaces
{
    public interface ISalaoRepository
    {
        Task<IEnumerable<Salao>> GetSaloesAsync();
    }
}
