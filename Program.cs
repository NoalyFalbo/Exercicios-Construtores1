using System;
using System.Globalization;

namespace exercicioClasses4
{

  class Program
  {

    static void Main(string[] args)
    {

      Console.Clear();

      //Produto p = new Produto();


      Console.WriteLine("Digite os dados do produto: ");
      Console.Write("Nome: ");
      string nome = Console.ReadLine();
      Console.WriteLine("Preço");
      double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.WriteLine("Quantidade no estoque: ");
      int quantidade = int.Parse(Console.ReadLine());

      Produto p = new Produto(nome, preco, quantidade);

      Console.WriteLine("Dados do Produto: " + p);

      Console.WriteLine();

      Console.WriteLine("Digite o número de produtos a ser adicionado no estoque:");
      int qnt = int.Parse(Console.ReadLine());
      p.AdicionarProdutos(qnt);
      Console.WriteLine("Dados atualizados: " + p);

      Console.WriteLine();

      Console.WriteLine("Digite o número de produtos a ser removido no estoque:");
      qnt = int.Parse(Console.ReadLine());
      p.RemoverProdutos(qnt);
      Console.WriteLine("Dados atualizados: " + p);

    }
  }
}