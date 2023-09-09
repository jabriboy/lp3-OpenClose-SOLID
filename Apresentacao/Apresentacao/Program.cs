// See https://aka.ms/new-console-template for more information
namespace Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto domestico = new Domesticos("Cadeira", 50.0, false, "Cadeira de madeira");
            Produto luxo = new Luxo("Relógio de Ouro", 1000.0, true, "Relógio de luxo");
            Produto eletronico = new Eletronicos("Smartphone", 800.0, true, "Smartphone premium");
            Produto remedio = new Remedios("Aspirina", 10.0, false, "Analgésico");

            ImprimirTaxa(domestico);
            ImprimirTaxa(luxo);
            ImprimirTaxa(eletronico);
            ImprimirTaxa(remedio);
        }

        static void ImprimirTaxa(Produto produto)
        {
            Console.WriteLine($"Nome: {produto.nome}");
            Console.WriteLine($"Descrição: {produto.descricao}");
            Console.WriteLine($"Valor: R${produto.valor:F2}");
            Console.WriteLine($"Importado: {produto.importado}");
            Console.WriteLine($"Taxa: R${produto.CalcularTaxa():F2}");
            Console.WriteLine();
        }
    }
}

