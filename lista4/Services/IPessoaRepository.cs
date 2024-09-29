using lista4.Models;

namespace lista4.Services
{
    public interface IPessoaRepository
    {
        public List<Pessoa> ObterTodosPessoa();
        public Pessoa ObterPessoaPorCpf(string cpf);

        public void Inserir(Pessoa novaPessoa);
    }
}

