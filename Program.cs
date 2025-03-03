using System.Reflection.Metadata;
using static System.Console;
namespace projeto13
{
    class Program
    {
        static void Main(String[]args)
        {
            WriteLine("executando");

            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            
            for(int contadorlinha = 0; contadorlinha < 10; contadorlinha++)
            
            {

           
           for(int contadorcoluna = 0; contadorcoluna < 10; contadorcoluna++)
           
            {
                Write("*");
              if (contadorcoluna >= contadorlinha)
              break;
            }
                 WriteLine("");

            }


            




            for(int contadorlinha = 0; contadorlinha < 10; contadorlinha++)
            {

            for(int contadorcoluna = 0; contadorcoluna <= contadorlinha; contadorcoluna++)
            {
                Write("*");
               
            }
                WriteLine("");
            }
            ReadLine();


        }
    }

}