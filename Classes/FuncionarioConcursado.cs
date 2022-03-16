using System;
using System.Collections.Generic;
using System.Globalization;

namespace POO_em_C_
{
    class FuncionarioConcursado : FuncionarioGeral //Herda da classe mãe FuncionarioGeral
    {
        // método que muda a cor das letras no prompt
        String color = "\u001B["; // função que muda a cor da letra no console.

        //metodos cosntrutores
        public FuncionarioConcursado(int tipo, int codigo, int tempoContrato, double salarioBase) {
            // tentar deixar vazio e ver se vai rodar...
            
        }

        public /*override*/ Double SalarioMensal(){
            return base.SalarioBase+base.TempoContrato*200;
        }

        public /*override*/ Double salarioNovo(){
            return (base.SalarioMensal()+dependentes.Count*100);
        }

        public void saidaDeDados(){
            Console.WriteLine();
            Console.WriteLine(color+"36"+"m"+"***** ENTRE COM OS DADOS DO FUNCIONÁRIO CONCURSADO *****"+color+"m");
            base.saidaDeDados();
            Console.WriteLine(String.Format("Salário mensal: R$ "+"%.2f", SalarioMensal()));
            Console.WriteLine("Quantidade de dependentes: "+dependentes.Count);
            /*for (Dependente dependente = this.dependentes) {
                Console.WriteLine("Idade dependente: ["+dependente.idade+"]");
            }*/

        }
        
    }
}
