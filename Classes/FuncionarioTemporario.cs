using System;

namespace POO_em_C_
{
    class FuncionarioTemporario : FuncionarioGeral
    {
        public FuncionarioTemporario(int tipo, int codigo, int tempoContrato, double salarioBase) 
        {

        }

        new public Double SalarioMensal()
        {
            return base.SalarioBase+base.TempoContrato*15;
        }
        public Double salarioNovo()
        {
            return SalarioMensal()+dependentes.Count*50;
        }
        new public void saidaDeDados()
        {
            Console.WriteLine();
            Console.WriteLine(colorGlobal+"32"+"m"+"***** ENTRE COM OS DADOS DO FUNCIONÁRIO TEMPORÁRIO *****"+colorGlobal+"m");
            base.saidaDeDados();
            Console.WriteLine(String.Format("Salário mensal: R$"+"%.2f", SalarioMensal()));
            Console.WriteLine("Quantidade de dependentes: ["+dependentes.Count+"]");

            foreach (Dependente dependente in dependentes)
            {
                Console.WriteLine("Idade dependente: ["+dependente.idade+"]");
            }
            Double cauculaSalario = 0;
            foreach (Dependente dependente in dependentes)
            {
                cauculaSalario = cauculaSalario*dependentes.Count;
            }
            Console.WriteLine("Salário mensal atualizado é de: R$ ");
            Console.WriteLine(colorGlobal+"32"+"m"+String.Format("%.2f", salarioNovo())+colorGlobal+"m");
            Console.WriteLine();
        }
    }
}
