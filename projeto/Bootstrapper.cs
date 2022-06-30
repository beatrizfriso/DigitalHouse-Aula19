using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using projeto.ViewModels;

namespace projeto
{

    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            // Inicializa o projeto
            base.Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // Define qual será o Controlador padrão
            // Nota: O controlador MainViewModel ainda não foi criado nessa etapa.
            base.DisplayRootViewFor<MainViewModel>();
        }
    }
}