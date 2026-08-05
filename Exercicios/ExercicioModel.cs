using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class ExercicioModel
    {
        //Área para declaração de variáveis globais
        private int num1;
        private int num2;
        private double num3;
        private double num4;
        private int resultado;

        //Método Construtor: Instância as variáveis na memória

        public ExercicioModel()
        {

            SetNum1(0);
            SetNum2(0);
            SetResultado(0);

        } //fim do Método Construtor

        public ExercicioModel(int num1, int num2)
        {
            SetNum1(num1);
            SetNum2(num2);
            SetResultado(0);
        } //fim do construtor

        public ExercicioModel(double num1, double num2)
        {
            SetNum3(num1);
            SetNum4(num2);
        }//Fim do Construtor

        //Métodos GETS E SETS
        //GET = Pegar, Obter, Consultar
        // Set = Alterar, Modificar, Configurar
        public int GetNum1()
        {
            return this.num1;
        }//fim do getNum1


        public void SetNum1(int num1)
        {
            this.num1 = num1;
        }//fim do SetNum1

        public int GetNum2()
        {
            return this.num2;
        }//fim do GetNum2

        public void SetNum2(int num2)
        {
            this.num2 = num2;
        }//fim do SetNum2

        public int GetResultado()
        {
            return this.resultado;

        }//fim do GetResultado

        public void SetResultado(int resultado)
        {
            this.resultado = resultado;
        }

        public double GetNum3()
        {
            return this.num3;
        }//fim do GetNum3

        public void SetNum3(double num3)
        {
            this.num3 = num3;
        }//fim do SetNum3

        public double GetNum4()
        {
            return this.num4;
        }//fim do GetNum4

        public void SetNum4(double num4)
        {
            this.num4 = num4;
        }//Fim do SetNum4
        public int Somar()
        {
            SetResultado(GetNum1() + GetNum2());
            return GetResultado();

        } //fim do metodo somar

        public int Subtrair()
        {
            SetResultado(GetNum1() - GetNum2());
            return GetResultado();
        }

        public int Multiplicar()
        {
            SetResultado(GetNum1() * GetNum2());
            return GetResultado();
        }//fim do Multiplicar

        public double Dividir()
        {
            if (GetNum2() < 0)
            {
                return -2;
            }

            else if (GetNum2() == 0)
            {
                return -1;
            }
            else
            {
                SetResultado(GetNum1() / GetNum2());
                return GetResultado();
            }//fim do If
        }//fim do Dividir


        public double Potencia(double bas, double expoente)
        {
            return Math.Pow(bas, expoente);
        }//Fim da Potência

        public double Raiz(double num)
        {
            return Math.Sqrt(num);
        }//Fim da Raiz

        public double Potencia()
        {
            return Math.Pow(GetNum3(), GetNum4());
        }//fim do potencia sem parâmetros

        public double RaizNum3()
        {
            return Math.Sqrt(GetNum3());
        }//fim do raiz num3

        public double RaizNum4()
        {
            return Math.Sqrt(GetNum4());
        }//fim do raiz num4 

    }
}//fim da classe
//fim do projeto
