using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public string Exercicio01(int ano)
        {
            if (ano % 4 == 0)
            {
                return ano + " é bissexto";
            }
            else
            {
                return ano + " não é bissexto!";
            }
        }//fim do ano Bissexto

        public string Exercicio02(int num)
        {
            if (num >= 100 && num <= 200)
            {
                return num + " está entre 100 e 200!";
            }
            else
            {
                return num + " não está entre 100 e 200";
            }
        }//fim do Exercicio02

        public string Exercicio03(int idade)
        {
            if (idade >= 16)
            {
                return idade + " Pode votar";
            }
            else
            {
                return idade + " Não pode votar";
            }
        }//fim do Exercicio 03

        public string Exercicio04(int intervalo01, int intervalo02, int numComp)
        {
            if (numComp >= intervalo01 && numComp <= intervalo02)
            {
                return numComp + " está no intervalo";
            }
            else

            {
                return numComp + " não está no intervalo";
            }
        }//fim do Exercício04

        public string Exercicio05()
        {
            int[] numeros = new int[10];//10 é o tamanho
            bool flagNumeros = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Informe o " + (i + 1) + " número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Pegar e buscar o número
            Console.WriteLine("Digite o número a ser buscado: ");
            SetNum1(Convert.ToInt32(Console.ReadLine()));

            //Achar o número
            for (int i = 0; i < numeros.Length; i++)
            {
                if (GetNum1() == numeros[i])
                {
                    flagNumeros = true;
                    break;
                }
                else
                {
                    flagNumeros = false;
                }
            }
            if (flagNumeros == true)
            {
                return "\nO número " + GetNum1() + " está entre os números digitados.";
            }
            else
            {
                return "\nO número " + GetNum1() + " não está entre os números digitados";
            }
        }//fim do Exercicio05

        public string Exercicio06(int medida1, int medida2, int medida3)
        {
            if (medida1 == medida2 && medida2 == medida3)
            {
                return " É Equilátero";
            }
            else if (medida1 == medida2 || medida2 == medida3 || medida1 == medida3)
            {
                return "É Isósceles";
            }
            else
            {
                return "É Escaleno";
            }
        }//fim do Exercicio06

        public string Exercicio07(int dia)
        {
            switch (dia)
            {
                case 1:
                    return "Domingo";
                case 2:
                    return "Segunda";
                case 3:
                    return "Terça";
                case 4:
                    return "Quarta";
                case 5:
                    return "Quinta";
                case 6:
                    return "Sexta";
                case 7:
                    return "Sábado";
                default:
                    return "Digite um número de 1 a 7";
            }
        }//Fim do Exercicio07

        public string Exercicio08(int SenhaDigitada)
        {
            int SenhaBD = 1234;
            int tentativa = 1;

            while (tentativa < 3)
            {

                if (SenhaDigitada == SenhaBD)
                {
                    return "Bem-vindo!";
                }
                Console.WriteLine("\nSenha Incorreta!Tente Novamente: ");
                string senha = Console.ReadLine();
                tentativa++;
            }
            return "\nSenha Bloqueada";
        }

        //ler um número inteiro e retornar todos os múltiplos menores que 100
        public string multiplo(int numero)
        {
            //contador
            int i = 1;//criando contador e definir o ponto de partida
            string resultado = null;
            while (i < 100)
            {
                if (numero % i == 0)
                {
                    resultado += i + "\n";
                }
                //rodar meu contador
                i++;
            }//fim do WHILE
            return resultado;
        }//fim do método

        public string multiploFor(int numeroMult)
        {
            string resultado = "";
            for (int i = 1; i < 100; i++)
            {
                if (numeroMult % i == 0)
                {
                    resultado = i + "\n";
                }//fim do if
            }//fim do for
            return resultado;
        }//fim do método

        public bool EhPalindromo(string palin)
        {
            int fim = palin.Length - 1;//meço o tamanho de caracteres
            int inicio = 0;

            while (inicio < fim)
            {
                if (palin.Substring(inicio, 1) != palin.Substring(fim, 1))
                {
                    return false;
                }
                inicio++;
                fim--;
            }//fim do while
            return true;
        }//fim do método 

        public void ContarParImpar()
        {
            int contarPar = 0;
            int contarImpar = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + "º número: ");
                int num = Convert.ToInt32(Console.ReadLine());
                //Comparações
                if (num % 2 == 0)
                {
                    contarPar++;
                }
                else
                {
                    contarImpar++;
                }
            }//fim do for 
            Console.WriteLine("A quantidade de pares é: " + contarPar + "\nA quantidade de ímpares é: " + contarImpar);
        }//fim do parImpar

        public string Exercicio09(double hora1, double hora2)
        {
            if (hora1 > hora2)
            {
                return hora1 + " é mais tarde que " + hora2;
            }
            else
            {
                return hora2 + " é mais tarde";
            }
        }//fim do Exercício 09

        public string Exercicio10(int numero1, int numero2)
        {
            if (numero1 > numero2 && numero2 < numero1)
            {
                return (numero1 + " é maior que " + numero2);
            }
            else if (numero1 == numero2)
            {
                return " os dois números são iguais";
            }
            else
            {
                return (numero2 + " é maior que " + numero1);
            }
        }//fim do Exercicio 10

        public string Exercicio11(int conta1, int conta2, int conta3, int conta4)
        {
            double media = conta1 + conta2 + conta3 + conta4 / 5;

            return "A média é: " + media;
        }//fim do Exercicio 11

        public string Exercicio12;
    }//fim da classe
}//fim do projeto
 