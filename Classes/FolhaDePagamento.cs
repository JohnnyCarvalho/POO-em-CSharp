using System;
using System.Globalization;
using System.Collections.Generic;

namespace POO_em_C_
{
    class FolhaDePagamento
    {
        public static List<FuncionarioGeral> funcionarios;
        public static void Main(string[] args)
        {
            //troca a cor das letras no console.
            //String colorGlobal = "\u001B[";

            //Variável para entrada de dados
            String input = Console.ReadLine();

            Console.WriteLine("\nNesse programa iremos gerar um código que faz os cáuculos de salário dos colaboradores de acordo com seu status e número de dependentes, ou seja, se o colaborador for do tipo 1 ele é concursado e seu salário é x, se tipo 2, ele é temporário com salário y.");

            //cria um objeto a partir da lista fincionarios.
            funcionarios = new List<FuncionarioGeral>();

            //Aqui gera um contator para o loop a seguir.
            Console.Write("Digite a quantidade de colaboradores: ");
            int quantFunc = int.Parse(input);

            //loop para usuário colocar os dados de acordo com a quantidade de colaboradores ele colocou no contador.
            for (int i = 0; i < quantFunc; i++)
            {
                Console.WriteLine("\n***** DIGITE OS DADOS DO "+(i+1)+"º COLABORADOR *****");

                Console.Write("Tipo: ");
                int tipo = int.Parse(input);

                /*
                Nesse ponto, o código que o usuário vai inserir é um ID, ou seja, é único, por esse motivo essa parte tem que ser tratada para não correr o risco de duplicidade no ID, ou seja, duas pessoas terem o mesmo ID.
                */

                Console.Write("Código: ");
                int codigo = int.Parse(input);
                /*while (hasCodigo(funcionarios, codigo))
                {
                    Console.WriteLine(colorGlobal+"31"+"m"+"*********************** ERRO ***********************"+colorGlobal+"m");
                    Console.WriteLine("*****ESSE CÓDIGO JÁ EXISTE, CADASTRE UM CÓDIGO DIFERENTE *****");
                    codigo = int.Parse(input);
                }*/

                Console.WriteLine("Tempo de contratação: ");
                int tempoContr = int.Parse(input);

                
            }

            
        }
        /*public static Boolean hasCodigo(List<FuncionarioGeral> list, int codigo) {
            FuncionarioGeral func = list.( -> list.getCodigo() == codigo).findFirst().orElse(null);
            return func != null;
        }*/
    }
}
