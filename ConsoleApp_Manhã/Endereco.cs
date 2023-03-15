using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manhã
{
    public class Endereco
    {
        private string Rua;
        private string Numero;
        private string CEP;
        private string Bairro;
        private string Cidade;
        private string Estado;

        public Endereco(string rua, string numero, string cep, string bairro, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            CEP = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public string getEnderecoCompleto()
        {
            return Rua + " " + Numero + " ," + Bairro + " " + Cidade + " " + Estado;
        }

        public string getEnderecoCurto()
        {
            return Rua + " " + Numero;
        }

        public void setRua(string rua)
        {
            Rua = rua;
        }

        public string getRua() 
        {
            return Rua;
        }

        public void setNumero(string numero) 
        {
            Numero = numero;
        }

        public string getNumero()
        {
            return Numero;
        }

        public void setCEP(string cep)
        {
            CEP = cep;
        }

        public string getCEP()
        {
            return CEP;
        } 

        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }

        public string getBairro()
        {
            return Bairro;
        }

        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }

        public string getCidade()
        {
            return Cidade;
        }

        public void setEstado(string estado)
        {
            Estado = estado;
        }

        public string getEstado()
        {
            return Estado;
        }
        
    }
}
