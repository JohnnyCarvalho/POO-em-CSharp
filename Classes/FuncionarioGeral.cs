using System;
using System.Globalization;
using System.Collections.Generic;

namespace POO_em_C_
{
    class FuncionarioGeral
    {
        public String colorGlobal = "\u001B[";// função que muda a cor da letra no console.
        
        //atributes
        private int tipo, codigo, tempoContrato;
        private double salarioBase;
        public List<Dependente> dependentes = new List<Dependente>();// Lista para incluir os dependentes na classe Dependente

        //cosntrutores
        public FuncionarioGeral(){

        }
        public FuncionarioGeral(int tipo, int codigo, int tempoContrato, double salarioBase) {
            this.tipo = tipo;
            this.codigo = codigo;
            this.tempoContrato = tempoContrato;
            this.salarioBase = salarioBase;
        }

        //método de incrementação e encapsulamento
        public virtual int Tipo{
            get{return tipo;}
            set{Tipo=this.tipo;}
        }

        public virtual int Codigo {
            get{return codigo;}
            set{Codigo=this.codigo;}
        }

        public virtual int TempoContrato {
            get{return tempoContrato;}
            set{TempoContrato=this.tempoContrato;}
        }

        public virtual double SalarioBase {
            get{return salarioBase;}
            set{SalarioBase=this.salarioBase;}

        }

        //métodos de calculo do salário, cada método sera sobrescrito por uma classe filha.
        public Double SalarioMensal(){
            return 0.0;
        }
        public Double SalarioNovo(){
            return 0.0;
        }

        // Método de incluir a cada funcionário um dependente, o mesmo também terá a função de conferir se a quantidade não excede o limite permitido.
       public Boolean incluirDependente(Dependente quant){
            if (dependentes.Count>=5){
                return false;
            }
            else if(this.Tipo==1&&quant.Idade>21){
                return false;
            }
            else if(this.Tipo==2&&quant.Idade>18){
                return false;
            }
            else 
                dependentes.Add(quant);
                return true;
            
        }

        public void saidaDeDados() {
            Console.WriteLine("Tipo: "+this.tipo);
            Console.WriteLine("Código: "+this.codigo);
            Console.WriteLine("Tempo de contrataçã: "+this.tempoContrato);
            Console.WriteLine(String.Format("Salário base: R$ "+"%.2f"+this.salarioBase));
            
        }

    }
}
