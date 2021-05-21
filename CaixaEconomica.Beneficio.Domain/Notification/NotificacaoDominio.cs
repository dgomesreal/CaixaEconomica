using CaixaEconomica.Beneficio.Domain.Interfaces.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEconomica.Beneficio.Domain.Notification
{
    public class NotificacaoDominio : INotificacaoDominio
    {
        private List<string> _errormensagem = new List<string>();
        public IEnumerable<string> ErrorMensagem => _errormensagem;

        private List<string> _avisomenssagem = new List<string>();
        public IEnumerable<string> AvisoMensagem => _avisomenssagem;

        public void AddAviso(string mensagem)
        {
            _avisomenssagem.Add(mensagem);
        }

        public void AddErro(string mensagem)
        {
            _errormensagem.Add(mensagem);
        }

        public bool Validado()
        {
            if(_errormensagem.Any())
                throw new ArgumentException(string.Join(". ", _errormensagem.ToArray()));
            return true;
        }

        public bool TemAviso()
        {
            return _avisomenssagem.Any();
        }
    }
}
