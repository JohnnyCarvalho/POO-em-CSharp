using System;
using System.Globalization;

namespace POO_em_C_
{
    class Dependente
    {
        public int idade;//atributos

        public Dependente(int idade) {// contrutores
            this.idade = idade;
        }

        //getter and setter
        public int Idade{
            get{return Idade;}
            set{Idade=value;}
        }
        
    }
}
