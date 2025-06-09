using System;

namespace pedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random random = new Random();

            int pontuacaoJogador = 0;
            int pontuacaoOponente = 0;
            int totalPartidas = 0;

            Console.WriteLine("--- Bem-vindo ao pedra, papel e tesoura! ---");
            Console.WriteLine("Por favor insira a quantidade de partidas que deseja jogar:");

            while (true)
            {
                string quantidadeTotalPartidas = Console.ReadLine() ?? "";
                if (!int.TryParse(quantidadeTotalPartidas, out totalPartidas))
                {
                    Console.WriteLine("Escolha inválida, favor insira numericamente a quantidade de partidas que deseja participar");
                }
                else
                {
                    Console.WriteLine($"\nVocê escolheu jogar {totalPartidas} partidas.");
                    break;
                }
            }

            int rodadasJogadas = 0;
            while (rodadasJogadas < totalPartidas)
            {
                Console.WriteLine($"Pontuação do jogador - {pontuacaoJogador}.\nPontuação do oponente - {pontuacaoOponente}");
                Console.WriteLine($"\nPor favor insira 1 para Pedra, 2 para Papel, 3 para Tesoura e '0' para Sair");
                string escolhaDoJogador = Console.ReadLine() ?? "";

                if (!int.TryParse(escolhaDoJogador, out int escolhaJogador))
                {
                    Console.WriteLine("Escolha inválida, favor insira 1 para Pedra, 2 para Papel ou 3 para Tesoura");
                    continue;
                }

                string nomeEscolhaJogador = "";
                if (escolhaJogador == 1) nomeEscolhaJogador = "Pedra";
                else if (escolhaJogador == 2) nomeEscolhaJogador = "Papel";
                else if (escolhaJogador == 3) nomeEscolhaJogador = "Tesoura";
                Console.WriteLine($"Você escolheu {nomeEscolhaJogador}!");

                if (escolhaJogador == 0)
                {
                    Console.WriteLine($"\nVocê decidiu sair do jogo.");
                    break;
                }

                int escolhaOponente = random.Next(1, 4);

                if (escolhaOponente == escolhaJogador)
                {
                    Console.WriteLine("\nEmpate!");
                }
                else if ((escolhaJogador == 1 && escolhaOponente == 3) || (escolhaJogador == 2 && escolhaOponente == 1) || (escolhaJogador == 3 && escolhaOponente == 2))
                {
                    Console.WriteLine("\nJogador ganhou essa rodada.");
                    pontuacaoJogador++;
                }
                else
                {
                    Console.WriteLine("Oponente ganhou essa rodada.");
                    pontuacaoOponente++;
                }
                rodadasJogadas++;
            }


                Console.WriteLine("\n --- Fim de Jogo ---");
                if (pontuacaoJogador > pontuacaoOponente)
                {
                    Console.WriteLine($"Você ganhou!!!");
                }
                else if (pontuacaoOponente > pontuacaoJogador)
                {
                    Console.WriteLine($"Oponente ganhou!!!");
                }
                Console.WriteLine($@"Pontuação:
                Jogador - {pontuacaoJogador}.
                Oponente - {pontuacaoOponente}.");
        }
    }
}