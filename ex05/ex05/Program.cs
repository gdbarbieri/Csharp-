Console.WriteLine("Insira a senha:");
int senha = int.Parse(Console.ReadLine());

while (senha != 2002)
{

    Console.WriteLine("Senha inválida!!");
    senha = int.Parse(Console.ReadLine());

}
//levando em consideração uma senha pré determinada "2002"
