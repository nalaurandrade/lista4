using Microsoft.AspNetCore.Mvc;

namespace lista4.Models
{
    [ApiController]
    [Route("api/pessoa")]
    public class PessoaController : ControllerBase
    {
        private static List<Pessoa> listaPessoas = new List<Pessoa>();

        [HttpPost]
        [Route("AdicionarPessoa")]

        public IActionResult CriarPessoa(Pessoa novaPessoa)
        {
            listaPessoas.Add(novaPessoa);
            return Ok("Pessoa Adicionada!");
        }

        [HttpGet]
        [Route("Atualizar/{nomeBusca}")]
        public IActionResult Atualizar(string nomeBusca, Pessoa pessoaAtualizado)
        {
            Pessoa? resultadoBusca = listaPessoas
                                 .Where(pessoa => pessoa.Nome == nomeBusca)
                                 .FirstOrDefault();

            if (resultadoBusca is null)
                return NotFound($"{nomeBusca} não encontrado");

            resultadoBusca.Nome = pessoaAtualizado.Nome;

            return Ok("Atualizado com sucesso");
        }

        [HttpDelete]
        [Route("Remover")]
        public IActionResult Remover(string nomeBusca)
        {
            Pessoa? resultadoBusca = listaPessoas
                                    .Where(pessoa => pessoa.Nome == nomeBusca)
                                    .FirstOrDefault();
            if (resultadoBusca is null)
                return NotFound($"{nomeBusca} não encontrado");

            listaPessoas.Remove(resultadoBusca);

            return Ok("Pessoa removida com sucesso!");
        }

        [HttpGet]
        [Route("BuscarTodas")]
        public IActionResult BuscarTodas()
        {
            return Ok(listaPessoas);
        }
        /*
        [HttpGet]
        [Route("BuscarAlturaMaior")]
        public IActionResult BuscarAlturaMaior(double pAltura)
        {
            return Ok(listaPessoas.Where(pessoa => pessoa.altura >= pAltura));
        }
        */
        [HttpGet]
        [Route("BuscarPorCPF")]
        public IActionResult BuscarPorCPF(string cpf)
        {
            return Ok(listaPessoas.Where(pessoa => pessoa.cpf == cpf));
        }

        [HttpGet]
        [Route("BuscarIMCBom")]
        public IActionResult BuscarIMCBom(string imc)
        {
            return Ok(listaPessoas.Where(pessoa => pessoa.imc  <= 24));
        }
    }
}
