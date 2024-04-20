using FinancasdeBolso.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasdeBolso.Repositories
{
    public interface ITransicaoRepositorio
    {
        void Add(Transacao transacao);
        void Delete(Transacao transacao);
        List<Transacao> GetAll();
        void Update(Transacao transacao);
    }
}
