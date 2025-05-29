using System;

namespace pedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int pontuacaoJogador = 0;
            int pontuacaoOponente = 0;

            Console.WriteLine("Bem-vindo ao pedra, papel, tesoura!\n");

            while (pontuacaoJogador != 3 && pontuacaoOponente != 3)
            {
                Console.WriteLine($"Pontuação do jogador - {pontuacaoJogador}. Pontuação do oponente - {pontuacaoOponente}\n");
                Console.WriteLine($"Por favor insira 'pedra' para pedra, 'papel' para papel, 'tesoura' para tesoura e 'sair' para sair");
                string escolhaJogador = Console.ReadLine();

                if (escolhaJogador == "sair")
                {
                    Console.WriteLine($"Pontuação: Jogador - {pontuacaoJogador}. Oponente - {pontuacaoOponente}\n");
                    break;
                }

                int escolhaOponente = random.Next(0, 3);

                if (escolhaOponente == 0)
                {
                    Console.WriteLine("\nOponente escolheu pedra.");

                    switch (escolhaJogador)
                    {
                        case "pedra":
                            Console.WriteLine("Empate!");
                            break;
                        case "papel":
                            Console.WriteLine("Jogador ganhou essa rodada.");
                            pontuacaoJogador++;
                            break;
                        default:
                            Console.WriteLine("Oponente ganhou essa rodada.");
                            pontuacaoOponente++;
                            break;
                    }
                }
                else if (escolhaOponente == 1)
                {
                    Console.WriteLine("\nOponente escolheu papel.");

                    switch (escolhaJogador)
                    {
                        case "pedra":
                            Console.WriteLine("Oponente ganhou essa rodada.");
                            pontuacaoOponente++;
                            break;
                        case "papel":
                            Console.WriteLine("Empate!");
                            break;
                        default:
                            Console.WriteLine("Jogador ganhou essa rodada.");
                            pontuacaoJogador++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nOponente escolheu tesoura.");

                    switch (escolhaJogador)
                    {
                        case "pedra":
                            Console.WriteLine("Jogador ganhou essa rodada.");
                            pontuacaoJogador++;
                            break;
                        case "papel":
                            Console.WriteLine("Oponente ganhou essa rodada.");
                            pontuacaoOponente++;
                            break;
                        default:
                            Console.WriteLine("Empate!");
                            break;
                    }
                }
            }

            if (pontuacaoJogador == 3)
            {
                Console.WriteLine($@"Você ganhou! 
                Pontuação:
                    Jogador - {pontuacaoJogador}.
                    Oponente - {pontuacaoOponente}.");
            }
            else if (pontuacaoOponente == 3)
            {
                Console.WriteLine($@"Oponente ganhou!
                Pontuação:
                    Jogador - {pontuacaoJogador}.
                    Oponente - {pontuacaoOponente}.");
            }
            else
            {
                Console.WriteLine($@"Você desistiu.
                Pontuação:
                    Jogador - {pontuacaoJogador}.
                    Oponente - {pontuacaoOponente}.");
            }
        }
    }
}