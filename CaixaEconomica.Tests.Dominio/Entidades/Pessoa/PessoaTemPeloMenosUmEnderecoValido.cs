using CaixaEconomica.Beneficio.Domain.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CaixaEconomica.Tests.Dominio.Entidades.Pessoa
{
    [TestClass]
    public class PessoaTemPeloMenosUmEnderecoValido
    {
        private CaixaEconomica.Beneficio.Domain.Entidades.Pessoa pessoa;
        private Endereco endereco;

        [TestInitialize]
        public void Init()
        {
            pessoa = new Beneficio.Domain.Entidades.Pessoa();
            endereco = new Endereco();
            pessoa.AdicionarEndereco(endereco);
        }

        [TestMethod]
        public void PessoaTemEnderecoValido()
        {
            Assert.IsTrue(pessoa.Enderecos.Any());

        }
    }
}
