using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao
{
    public class Domesticos : Produto
    {
        public Domesticos(string nome, double valor, bool importado, string descricao) : base(nome,valor,importado,descricao){
        }

        public override double CalcularTaxa()
        {
            double multiplicador = importado ? 1.5 : 1.0;
            return valor * multiplicador;
        }
    }

    public class Luxo : Produto
    {
        public Luxo(string nome, double valor, bool importado, string descricao) : base(nome, valor, importado, descricao)
        {
        }

        public override double CalcularTaxa()
        {
            double multiplicador = importado ? 5.5 : 1.0;
            return valor * multiplicador;
        }
    }

    public class Eletronicos : Produto
    {
        public Eletronicos(string nome, double valor, bool importado, string descricao) : base(nome, valor, importado, descricao)
        {
        }

        public override double CalcularTaxa()
        {
            double multiplicador = importado ? 3.5 : 1.0;
            return valor * multiplicador;
        }
    }

    public class Remedios : Produto
    {
        public Remedios(string nome, double valor, bool importado, string descricao) : base(nome, valor, importado, descricao)
        {
        }

        public override double CalcularTaxa()
        {
            double multiplicador = importado ? 2.5 : 1.0;
            return valor * multiplicador;
        }
    }

}
