using CaixaEconomica.Beneficio.Domain.Notification;
using System.Collections.Generic;
using System.Linq;

namespace CaixaEconomica.Beneficio.Domain.Entidades
{
    public class Pessoa : Entidade
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public int QtdDeFilhos { get; set; }

        //02 Empregado
        //11 Profissional Liberal        
        public int CodigoOcupacao { get; set; }

        //Relacionamento de 1(Pessoa) para muitos(Endereco)
        //Backing Field
        private readonly HashSet<Endereco> _enderecos = new HashSet<Endereco>();
        public IEnumerable<Endereco> Enderecos => _enderecos.ToList().AsReadOnly();
        public Pessoa()
        {
            //Assim ate que seja implementado a injecao de dependencias
            SetNotificacao(new NotificacaoDominio());
        }
        public void AdicionarEndereco(Endereco endereco)
        {
            if (endereco == null)
            {
                NotificacaoDominio.AddErro("Erro: Endereco deve ser instanciado!");
            }
            else
            {
                endereco.Validar();
                if (EhValido())
                    _enderecos.Add(endereco);
            }
        }

        //Relacionamento 1(Pessoa) para muitos(BeneficioPessoa)
        private readonly HashSet<BeneficioPessoa> _beneficioPessoas = new HashSet<BeneficioPessoa>();
        public IEnumerable<BeneficioPessoa> BeneficioPessoas => _beneficioPessoas.ToList().AsReadOnly();
    }
}
