using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manhã
{
    public class Produto
    {
        private int Id;
        private string Descricao;
        private decimal Valor;

        public Produto(int id, string descricao, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }   

        public int getId()
        {
            return Id;
        }

        public void setId(int id) 
        {
            if (id > 0)
            {
                Id = id;
            }
            Id = id;
        }
        public string getDescricao()
        {
            return Descricao;
        }

        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void setValor(decimal valor)
        {
            Valor = valor;
        }
        public decimal getValor()
        {
            return Valor;
        }
    }
}
