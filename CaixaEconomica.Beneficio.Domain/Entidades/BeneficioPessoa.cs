using System;

namespace CaixaEconomica.Beneficio.Domain.Entidades
{
    public class BeneficioPessoa : Entidade
    {
        public int BeneficioId { get; set; }
        public virtual Beneficio Beneficio { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public DateTime DataInicioBeneficio { get; set; }
        public DateTime DataFimBeneficio { get; set; }
        public decimal Valor { get; set; }
        public int QtdParcelas { get; set; }
        public int QtdParcelasPagas { get; set; }
        public void SetPessoa(Pessoa pessoa)
        {
            if (pessoa != null)
                PessoaId = pessoa.Id;
        }
        public void SetBeneficio(Beneficio beneficio)
        {
            if (beneficio != null)
                BeneficioId = beneficio.Id;
        }
    }
}
