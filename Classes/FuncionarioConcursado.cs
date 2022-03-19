using System;
using System.Collections.Generic;
using System.Globalization;

namespace POO_em_C_
{
    class FuncionarioConcursado : FuncionarioGeral //Herda da classe mãe FuncionarioGeral
    {
        // método que muda a cor das letras no prompt

        //metodos cosntrutores
        public FuncionarioConcursado(int tipo, int codigo, int tempoContrato, double salarioBase) {
            // tentar deixar vazio e ver se vai rodar...
            
        }

        new public /*override*/ Double SalarioMensal(){
            return base.SalarioBase+base.TempoContrato*200;
        }

        public /*override*/ Double salarioNovo(){
            return (base.SalarioMensal()+dependentes.Count*100);
        }

        public override void saidaDeDados(){
            Console.WriteLine();
            Console.WriteLine(colorGlobal+"36"+"m"+"***** FUNCIONÁRIO CONCURSADO *****"+colorGlobal+"m");
            base.saidaDeDados();
            Console.WriteLine("Salário mensal: R$ ", SalarioMensal().ToString("F"));
            Console.WriteLine("Quantidade de dependentes: "+dependentes.Count);
            foreach (Dependente dependente in dependentes)
            {
                Console.WriteLine("Idade dependente: ["+dependente.idade+"]");
                
            }
            double cauculaSalario = 0;
            foreach (Dependente dependente in this.dependentes)
            {
                cauculaSalario = cauculaSalario*dependentes.Count;
                
            }
            Console.Write("Salário mensal atualizado é: R$ ");
            Console.WriteLine(colorGlobal+"32"+"m", salarioNovo().ToString("F")+colorGlobal+"m");
            Console.WriteLine();

        }
        
    }
}
