using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 { 

public class Class1
{
	public Class1()
	{
		private int[] cestudiantes = new int[40];

	public Notas() {}

	public Notas(int[] cestudiantes)
{
		Cestudiantes = cestudiantes;
}
	public void Est(int[] cestudiantes)
    {
		this.Cestudiantes = cestudiantes;
    }

    public int validar(String Mensaje)
    {
        int num = 0, v;
        do
        {
            v = 1;
            try
            {
                Console.Write(Mensaje);
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception error)
            {
                v = 0;
                Console.WriteLine("No se aceptan letras", error.Message);
            }
        } while (v == 0);
        return num;
    }

  }
}
