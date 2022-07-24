// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("\n\n\n");
Console.WriteLine("Digite sua senha: ");
string senha = Console.ReadLine();
string senha2 = "3103001458";
if (senha == senha2)
{
    Console.Write("Bem vindo ");
    Console.WriteLine(nome);
}
else
{
    Console.Write("Senha incorreta.");
}