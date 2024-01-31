using ConsoleApp1;

public class Cest
{
    public static void Main(string[] args)
    {
        Notas c = new Notas();
        int[,]no = new int[40,5];
        int cE, fila, col;

        do
        {
            cE = c.validar("Digite la cantidad de estudiantes: ");

        } while (cE <= 0 || cE > 40);

        for(fila = 0; fila < cE; fila++)
        {

            do
            {
                no[fila,0] = c.validar("Nota del estudiante " + (fila + 1) + ":");
            }








        }



    }


}


