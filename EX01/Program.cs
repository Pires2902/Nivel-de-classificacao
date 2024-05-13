using System;
using System.Text.RegularExpressions;
using System.Text;

namespace EX01;

class Program{

static void Main(string[] args){

Console.OutputEncoding = Encoding.UTF8;
//Declaração de variaveis 
string classificacao;
string Nome;
int XP;
bool deNovo = true;
string Quer;
string paragrafo = "##########################";
//Input
Console.WriteLine(paragrafo);
Console.WriteLine("Olá! Bem vindo ao programa de classificação do heroi! ");
Console.WriteLine(paragrafo);

while(deNovo == true)
{
Console.WriteLine("Qual é seu o nome, heroi? ");
Nome = Console.ReadLine();

Console.WriteLine(paragrafo);
Console.WriteLine("Quanta experiência você possui?");
XP = int.Parse(Console.ReadLine());

//process
if (XP <= 1000)
{
    classificacao = "Ferro";
    Console.WriteLine(paragrafo);
    Console.WriteLine("O Herói de nome " + Nome + " está no nível " + classificacao);

}
else if (XP >= 1001 && XP <= 2000)
{
    classificacao = "Bronze";
    Console.WriteLine(paragrafo);
    Console.WriteLine("O Herói de nome " + Nome + " está no nível " + classificacao);

}
else if (XP >= 2001 && XP <= 5000)
{
    classificacao = "Prata";
    Console.WriteLine(paragrafo);
    Console.WriteLine("O Herói de nome " + Nome + " está no nível " + classificacao);

}
else if (XP >= 5001 && XP <= 7000)
{
    classificacao = "Ouro";
    Console.WriteLine(paragrafo);
    Console.WriteLine("O Herói de nome " + Nome + " está no nível " + classificacao);

}
else if (XP >= 7.001 && XP <= 8000)
{
    classificacao = "Platina";
    Console.WriteLine(paragrafo);
    Console.WriteLine("O Herói de nome " + Nome + " está no nível " + classificacao);


}
else if (XP >= 8.001 && XP <= 9000)
{
    classificacao = "Ascendente";
    Console.WriteLine(paragrafo);
    Console.WriteLine("O Herói de nome " + Nome + " está no nível " + classificacao);

}
else if (XP >= 9.001 && XP <= 10000)
{
    classificacao = "Imortal";
    Console.WriteLine(paragrafo);
    Console.WriteLine("O Herói de nome " + Nome + " está no nível " + classificacao);

}
else if (XP >= 10001)
{
    classificacao = "Radiante";
    Console.WriteLine(paragrafo);
    Console.WriteLine("O Herói de nome " + Nome + " está no nível " + classificacao);

}

//Fim
Console.WriteLine("##########################");
Console.WriteLine("Você quer classificar um novo heroi?(Sim/Nao) ");
Quer = Console.ReadLine();
if (Quer.ToLower() == "sim")
{

    deNovo = true;

}else
{
    deNovo = false;
    Console.WriteLine("##########################");
    Console.WriteLine("Obrigado por usar o programa de classificação do heroi!");
}

}
}
}

