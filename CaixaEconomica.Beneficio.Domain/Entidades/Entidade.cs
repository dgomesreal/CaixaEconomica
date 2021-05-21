using CaixaEconomica.Beneficio.Domain.Interfaces.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEconomica.Beneficio.Domain.Entidades
{
    public abstract class Entidade
    {
        private INotificacaoDominio _notificationDominio;
        protected INotificacaoDominio NotificacaoDominio { 
            get {
                return _notificationDominio == null ?
                    throw new Exception("Erro: Notificação Domínio Não Foi Instanciado. Favor chamar o método notificação") 
                    : _notificationDominio;   
            }
        }

        public void SetNotificacao(INotificacaoDominio notificacaoDominio)
        {
            _notificationDominio = notificacaoDominio;
        }

        public bool EhValido()
        {
            return _notificationDominio.Validado();
        }
    }
}
