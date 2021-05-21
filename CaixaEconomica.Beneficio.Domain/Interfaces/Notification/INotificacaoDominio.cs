using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEconomica.Beneficio.Domain.Interfaces.Notification
{
    public interface INotificacaoDominio
    {
        bool Validado();
        bool TemAviso();
        IEnumerable<string> ErrorMensagem { get; }
        IEnumerable<string> AvisoMensagem { get; }
        void AddErro(string mensagem);
        void AddAviso(string mensagem);
    }
}
