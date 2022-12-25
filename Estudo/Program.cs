using Estudo;

namespace Curso
{
    public class Program {
        public static void Main(string[] args){
            
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            
            Console.WriteLine("Digite a quantidade de produtos: ");
            int quant = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
        
            Produtos p = new Produtos(nome, quant, preco);

            Console.WriteLine(p.ToString());

            Console.WriteLine("Deseja adicionar produtos? S para sim, N para não: ");
            
            string opt = Console.ReadLine();
            opt = opt.ToUpper();
            while (opt.ToUpper() != "S" || opt.ToUpper() != "N")
            {
                if (opt.ToUpper() == "S") { break; }
                else
                {
                    Console.WriteLine("Opção incorreta. Favor prencher com S para sim e N para não");
                    opt = Console.ReadLine();
                    opt = opt.ToUpper();
                }
             }
            if (opt == "S") 
            {
                Console.Write("Adicionar quantos produtos: ");
                int qte = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qte);
                Console.WriteLine("Dados atualizados: ");
                Console.Write(p.ToString());
            }

            Console.WriteLine("Deseja remover produtos? S para sim, N para não: ");

            opt = Console.ReadLine().ToString().ToUpper();

            while (opt.ToUpper() != "S" || opt.ToUpper() != "N")
            {
                if (opt.ToUpper() == "S") 
                {
                    Console.WriteLine("Digite a quantidade de produtos a serem removidos: ");
                    quant = int.Parse(Console.ReadLine());
                    p.RemoverProdutos(quant);
                    Console.WriteLine("Dados atualizados: ");
                    Console.Write(p.ToString());
                    break;
                }
                else
                {
                    Console.WriteLine("Opção incorreta. Favor prencher com S para sim e N para não");
                    opt = Console.ReadLine();
                    opt = opt.ToUpper();
                }
            }



        }
    }
}