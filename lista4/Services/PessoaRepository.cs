using lista4.Models;
using System.Collections.Generic;
using System.Linq;

namespace lista4.Services
{
    public class PessoaRepository : IPessoaRepository
    {
        private static List<Pessoa> dadosPessoaList = new List<Pessoa>();
        public PessoaRepository() { }
        public void Inserir (Pessoa novaPessoa)
		{
			dadosPessoaList.Add(novaPessoa);
		}
        public List<Pessoa> ObterTodosPessoa()
        {
            return dadosPessoaList;
        }

        public Pessoa ObterPessoaPorCpf(string cpf)
        {
            return dadosPessoaList.FirstOrDefault(p => p.cpf == cpf);
        }
    }
}
