using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao
{
    public abstract class Produto : Taxa
    {
        public string nome { get; set; }
        public double valor { get; set; }
        public bool importado { get; set; }
        public string descricao { get; set; }

        public Produto(string nome, double valor, bool importado, string descricao) { 
            this.nome = nome;
            this.valor = valor;
            this.importado = importado;
            this.descricao = descricao;
        }

        public virtual double CalcularTaxa()
        {
            double multiplicador = importado ? 1.0 : 0.0;
            return valor * multiplicador;
        }
    }
}
