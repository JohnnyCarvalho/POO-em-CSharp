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
            String colorGlobal = "\u001B[";

            //Variável para entrada de dados
            //String Console.ReadLine() = Console.ReadLine();

            Console.WriteLine("\nNesse programa iremos gerar um código que faz os cáuculos de salário dos colaboradores de acordo com seu status e número de dependentes, ou seja, se o colaborador for do tipo 1 ele é concursado e seu salário é x, se tipo 2, ele é temporário com salário y.");

            //cria um objeto a partir da lista fincionarios.
            funcionarios = new List<FuncionarioGeral>();

            //Aqui gera um contator para o loop a seguir.
            Console.Write("Digite a quantidade de colaboradores: ");
            int quantFunc = int.Parse(Console.ReadLine());

            //loop para usuário colocar os dados de acordo com a quantidade de colaboradores ele colocou no contador.
            for (int i = 0; i < quantFunc; i++)
            {
                Console.WriteLine("\n***** DIGITE OS DADOS DO "+(i+1)+"º COLABORADOR *****");

                Console.Write("Tipo: ");
                int tipo = int.Parse(Console.ReadLine());
                

                /*
                Nesse ponto, o código que o usuário vai inserir é um ID, ou seja, é único, por esse motivo essa parte tem que ser tratada para não correr o risco de duplicidade no ID, ou seja, duas pessoas terem o mesmo ID.
                */

                Console.Write("Código: ");
                int codigo = int.Parse(Console.ReadLine());
            
                Console.Write("Tempo de contratação: ");
                int tempoContr = int.Parse(Console.ReadLine());

                Console.Write("Salário base: ");
                double salarioBase = double.Parse(Console.ReadLine());

                //entrada de dependentes se holver
                Console.WriteLine("\n## QUANTIDADE MÁXIMA DE DEPENDENTE POR COLABORADOR É DE 5 ##");
                Console.WriteLine(colorGlobal+"36"+"m"+"****OBS: se cadastra a quantidade ou idade acima da máxima permitida, iremo retirar da lista automáticamente."+colorGlobal+"m");
                Console.Write("Digite a quantidade: ");
                int quantDep = int.Parse(Console.ReadLine());

                // Cria uma lista de dependetes para que sejam adicionador.
                List<Dependente> dependentes = new List<Dependente>();

                Console.WriteLine("Idade dos dependentes: ");
                if (tipo==1)
                {
                    Console.WriteLine(colorGlobal+"32"+"m"+"\nIdade máxima permitida 21 anos!"+colorGlobal+"m");
                }
                else if (tipo==2)
                {
                    Console.WriteLine(colorGlobal+"32"+"m"+"\nIdade máxima permitida 18 anos!"+colorGlobal+"m");
                }
                int contador = 0;
                while (contador<quantDep)
                {
                    Console.Write("\nDigite a idade do "+(contador+1)+"º dependente: ");
                    int idade = int.Parse(Console.ReadLine());

                    //cria um objeto dep para inserir os dependentes dentro da classe Dependente
                    Dependente dep = new Dependente(idade);

                    dependentes.Add(dep);

                    contador++;
                }
                if (tipo==1)
                {
                    FuncionarioConcursado funcionario = new FuncionarioConcursado(tipo, codigo, tempoContr, salarioBase);

                    
                // inclui os dependente na classe, primeiro faz o teste lógico na classe mãe, no método incluir dependente
                // se estiver tudo ok os dependentes serão inclusos na classe.
                foreach (Dependente dep in dependentes)
                {
                    funcionario.incluirDependente(dep);
                }
                // fim da associação de dependentes para os funcionários concursado
                funcionarios.Add(funcionario);
            }
            else if(tipo==2)
                {
                    FuncionarioTemporario funcionario = new FuncionarioTemporario(tipo, codigo, tempoContr, salarioBase);

                    foreach (Dependente dep in dependentes)
                    {
                        funcionario.incluirDependente(dep);
                    }
                    // fim da associação de dependentes para os funcionários temporários
                    funcionarios.Add(funcionario);
                }
            }
            foreach (FuncionarioGeral funcionario in funcionarios)
            {
                funcionario.saidaDeDados();
            }
        }
    }
}
