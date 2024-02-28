namespace ATV2_CJ3022251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario;

            Console.WriteLine("escreva seu salário :");

            salario = float.Parse(Console.ReadLine());

            salario = salario + (float)(25.0f / 100.0f) * salario;

            Console.WriteLine("seu novo salário é : {0}", salario);
               


           
        }
    }
}
