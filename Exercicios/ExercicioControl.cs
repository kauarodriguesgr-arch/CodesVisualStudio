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
                "4.Multiplicação\n" +
                "5.Potência\n" +
                "6.Potênia com Parâmetros\n" +
                "7.Raiz\n" +
                "8.Raiz com Parâmetros\n" +
                "9.Ano Bissexto\n" +
                "10.Número entre 100 e 200\n" +
                "11.Verifique se a pessoa pode votar\n" +
                "12.Verifique se o número está no intervalo\n" +
                "13.Verifique se o número está entre os 10 valores\n" +
                "14.Verifique o triângulo\n" +
                "15.Verifique o dia da semana\n" +
                "16.Veja se a senha está correta\n" +
                "17.Múltiplo\n" +
                "18.MúltiploFor\n" +
                "19.Palindromo\n" +
                "20.Contar Pares e Ímpares\n" +
                "21.Horários\n" +
                "22.Comparar os números\n" +
                "23.Calcule a média\n" +
                "24.Vetores\n" +
                "25.Procurar número no vetor\n" +
                "26.Inverso\n" +
                "27.Pares\n" +
                "28.Média\n" +
                "29.Nomes com a letra A\n" +
                "30.Números acima da média\n" +
                "31.Leia 10 idades e exiba a maior\n" +
                "32 Leia 10 alturas e exiba a média\n" +
                "33. Salários abaixo de 1.200\n" +
                "34. Múltiplos de 5\n" +
                "35.Pares e Impares\n");
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
                    case 9:
                        Console.WriteLine("Informe o ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o Resultado
                        Console.WriteLine(this.modelo.Exercicio01(ano));
                        break;
                    case 10:
                        Console.WriteLine("Informe se o número está entre 100 e 200: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o Resultado
                        Console.WriteLine(this.modelo.Exercicio02(num));
                        break;
                    case 11:
                        Console.WriteLine("Verifique se a idade pode votar: ");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio03(idade));
                        break;
                    case 12:
                        Console.WriteLine("Digite o primeiro número: ");
                        int intervalo01 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        int intervalo02 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Verifique se o número está no intervalo: ");
                        int numComp = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio04(intervalo01, intervalo02, numComp));
                        break;
                    case 13:
                        Console.WriteLine(this.modelo.Exercicio05());
                        break;
                    case 14:
                        Console.WriteLine("Digite a medida do primeiro lado: ");
                        int medida1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite a medida do segundo lado: ");
                        int medida2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite a medida do terceiro lado: ");
                        int medida3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio06(medida1, medida2, medida3));
                        break;
                    case 15:
                        Console.WriteLine("Digite um dia da semana");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio07(dia));
                        break;
                    case 16:
                        Console.WriteLine("Digite sua senha: ");
                        int SenhaDigitada = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio08(SenhaDigitada));
                        break;
                    case 17:
                        Console.WriteLine("Informe um número: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado da operação
                        Console.WriteLine(this.modelo.multiplo(numero));
                        break;
                    case 18:
                        Console.WriteLine("Informe um número");
                        int numeroMult = opcao = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.multiploFor(numeroMult));
                        break;
                    case 19:
                        Console.WriteLine("Informe um número: ");
                        string palin = Console.ReadLine();
                        if (this.modelo.EhPalindromo(palin) == false)
                        {
                            Console.WriteLine("Não é Palíndromo");

                        }
                        else
                        {
                            Console.WriteLine("É Palíndromo");

                        }
                        break;
                    case 20:
                        this.modelo.ContarParImpar();
                        break;
                    case 21:
                        Console.WriteLine("Digite o primeiro horário: ");
                        double hora1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o segundo horário: ");
                        double hora2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio09(hora1, hora2));
                        break;
                    case 22:
                        Console.WriteLine("Digite o primeiro número: ");
                        int numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        int numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio10(numero1, numero2));
                        break;
                    case 23:
                        Console.WriteLine("Digite o primeiro número: ");
                        int conta1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        int conta2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o terceiro número: ");
                        int conta3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o quarto número: ");
                        int conta4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.modelo.Exercicio11(conta1, conta2, conta3, conta4));
                        break;
                    case 24:
                        this.modelo.preencherVetor();
                        this.modelo.mostrarVetor();
                        break;
                    case 25:
                        this.modelo.preencherVetor();
                        Console.WriteLine("Informe um número para procurar no vetor: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        //Chamar método de procura
                        Console.WriteLine(this.modelo.ProcurarNumero(num));
                        break;
                    case 26:
                        this.modelo.preencherVetor();
                        this.modelo.mostrarVetor();
                        this.modelo.Exercicio26();
                        break;
                    case 27:
                        this.modelo.Exercicio27();
                        break;
                    case 28:
                        this.modelo.Exercicio28();
                        break;
                    case 29:
                        this.modelo.Exercicio29();
                        break;
                    case 30:
                        this.modelo.Exercicio30();
                        break;
                    case 31:
                        this.modelo.Exercicio31();
                        break;
                    case 32:
                        this.modelo.Exercicio32();
                        break;
                    case 33:
                        this.modelo.Exercicio33();
                        break;
                    case 34:
                        this.modelo.Exercicio34();
                        break;
                    case 35:
                        this.modelo.Exercicio35();\
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do Escolha
            } while (GetOpcao() != 0);//fim do do..while
            }//fim do Método ExecutarMenu
    }//fim da classe
}//fim do projeto
