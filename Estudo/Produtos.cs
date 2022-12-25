using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Produtos
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quant { get; private set; }


        public Produtos(string nome, int quant, double preco)
        {
            _nome = nome;
            Quant = quant;
            Preco = preco;
        }

        public Produtos(string nome)
        {
            _nome = nome;
            Quant = 0;
            Preco = 0;
        }

        public Produtos()
        { 
        }

        public string Nome { 
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorEmEstoque() {
            return Preco * Quant;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quant += quantidade;
        }
        public void RemoverProdutos(int quantidade){
            Quant -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $"
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quant
            + " unidades, total: $"
            + ValorEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
