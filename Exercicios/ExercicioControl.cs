using Exercicios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class ExercicioControl
    {
        ExercicioModel modelo;//Conectando a Classe Model e Control
        private int opcao;

        public ExercicioControl()
        {
            this.modelo = new ExercicioModel();
            this.opcao = 0;
        }//Construtor Padrão/Vazio

        public int GetOpcao()
        {
            return this.opcao;
        }

        public void SetOpcao(int opcao)
        {
            this.opcao = opcao;
        }// fim do set

        public void Menu()
        {
            Console.WriteLine("\nEscolha uma das opcões abaixo:  \n" +
                "0.Sair\n" +
                "1.Soma\n" +
                "2.Subtração\n" +
                "3.Divisão\n" +
                "4.Multiplicação\n"+
                "5.Potência\n" +
                "6.Potênia com Parâmetros\n" +
                "7.Raiz\n" +
                "8.Raiz com Parâmetros\n");
            SetOpcao(Convert.ToInt32(Console.ReadLine()));
            Console.Clear();//Limpa o console
        }
        public void Coletar()
        {
            //Peguei os dois
            Console.WriteLine("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //vou passar para o construtor com parâmetro
            this.modelo = new ExercicioModel(num1, num2);
        }// fim do coletar = Pega os dois números digitados

        public void ColetarReal()
        {
            //Pegar dois números
            Console.WriteLine("Informe o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            //Chamar o construtor de reais
            this.modelo = new ExercicioModel(num1, num2);
        }//Fim do ColetorReal

        //Executar o Menu
        public void ExecutarMenu()
        {
            do
            {
                Menu();//Mostrar as Opções
                switch (GetOpcao())
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();//Pegar os dois números
                        Console.WriteLine("A soma é: " + this.modelo.Somar());//fazer a operação da Soma
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("A subtração é: " + this.modelo.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        //Validação
                        if (this.modelo.Dividir() == -2)
                        {
                            Console.WriteLine("Impossível Dividir por número negativo! ");

                        }
                        else if (this.modelo.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível Dividir por zero! ");

                        }
                        else
                        {
                            Console.WriteLine("A Divisão é: " + this.modelo.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("A multiplicação é: " + this.modelo.Multiplicar());
                        break;
                    case 5:
                        ColetarReal();
                        Console.WriteLine("A potência é: " + this.modelo.Potencia());
                        break;
                    case 6:
                        Console.WriteLine("Informe a base: ");
                        double bas = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o expoente: ");
                        double expoente = Convert.ToDouble(Console.ReadLine());
                        //Mostrar o resultado da operação
                        Console.WriteLine("A potência é: " + this.modelo.Potencia(bas, expoente));
                        break;
                    case 7:
                        ColetarReal();
                        Console.WriteLine("A raiz do primeiro número é: " + this.modelo.RaizNum3());
                        Console.WriteLine("A raiz do segundo número é " + this.modelo.RaizNum4());
                        break;
                    case 8:
                        Console.WriteLine("Informe o primeiro número: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        //chamar o método que calcula a raiz
                        Console.WriteLine("A raiz do primeiro número é: " + this.modelo.Raiz(num1));
                        Console.WriteLine("A raiz do segundo número é: " + this.modelo.Raiz(num2));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do Escolha
            } while (GetOpcao() != 0);//fim do do..while
            }//fim do Método ExecutarMenu
    }//fim da classe
}//fim do projeto
