using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manhã
{
    public class Veiculos
    {
        public int numeroRodas;
        public int numeroPortas;
        public string Cor;
        public int quantidadeAcento;
        public bool PagaImposto;

        public string ExibirDados()
        {
            return "N° Portas:" + numeroPortas + " cor:" + Cor;
        }
    }
}
