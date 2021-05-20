using System;
using System.Collections.Generic;
using System.Linq;

namespace CaixaEconomica.Beneficio.Domain.Entidades
{
    public class Beneficio : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicioVigencia { get; set; }
        public DateTime? DataFimVigencia { get; set; }
        public bool Ativo { get; set; }

        private readonly HashSet<BeneficioPessoa> _beneficioPessoas = new HashSet<BeneficioPessoa>();

        //Relacionamento 1(Beneficio) para muitos(BeneficioPessoa)
        public IEnumerable<BeneficioPessoa> BeneficioPessoas => _beneficioPessoas.ToList().AsReadOnly();
    }
}
