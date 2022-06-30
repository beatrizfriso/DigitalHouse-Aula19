using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.ViewModels
{
    public class MainViewModel : Screen
    {

        private string nomeCompleto;

        public string NomeCompleto
        {
            get
            {
                return nomeCompleto;
            }
            set
            {
                nomeCompleto = value;
                // Observa se o atributo/instância FirstName recebeu alguma atualização.
                base.NotifyOfPropertyChange(() => NomeCompleto);
            }
        }
    }
}