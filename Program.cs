using System;

namespace CalculadoraDePartidasRankeadas
{
    public class Jogador
    {
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }

        public Jogador(int vitorias, int derrotas)
        {
            Vitorias = vitorias;
            Derrotas = derrotas;
        }

        public int CalcularSaldo()
        {
            return Vitorias - Derrotas;
        }

        public string ClassificarNivel()
        {
            if (Vitorias < 10)
            {
                return "Ferro";
            }
            else if (Vitorias <= 20)
            {
                return "Bronze";
            }
            else if (Vitorias <= 50)
            {
                return "Prata";
            }
            else if (Vitorias <= 80)
            {
                return "Ouro";
            }
            else if (Vitorias <= 90)
            {
                return "Diamante";
            }
            else if (Vitorias <= 100)
            {
                return "Lendário";
            }
            else
            {
                return "Imortal";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de vitórias do jogador: ");
            int vitorias;
            while (!int.TryParse(Console.ReadLine(), out vitorias))
            {
                Console.WriteLine("Por favor, insira um número válido para a quantidade de vitórias.");
                Console.Write("Digite a quantidade de vitórias do jogador: ");
            }

            Console.Write("Digite a quantidade de derrotas do jogador: ");
            int derrotas;
            while (!int.TryParse(Console.ReadLine(), out derrotas))
            {
                Console.WriteLine("Por favor, insira um número válido para a quantidade de derrotas.");
                Console.Write("Digite a quantidade de derrotas do jogador: ");
            }

            Jogador jogador = new Jogador(vitorias, derrotas);
            int saldoVitorias = jogador.CalcularSaldo();
            string nivel = jogador.ClassificarNivel();

            Console.WriteLine($"O Herói tem de saldo de {saldoVitorias} está no nível de {nivel}");
        }
    }
}
