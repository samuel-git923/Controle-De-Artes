using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeArtes
{
    public interface IArte
    {
        String Nome { get; set; }
        String Descricao { get; set; }

        void ExibirDados();
    }
}
