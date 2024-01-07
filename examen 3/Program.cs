using System;
using System.Reflection.PortableExecutable;
using System.Timers;

public class Program
{
    static void Main()
    {
        string resp="Si";
        ConteoElectoral Mi = new ConteoElectoral();

        while(resp=="Si")
        {
            Console.WriteLine("Introduzca el voto:(Verde,Blanca,Rosa)");
            string voto = Console.ReadLine();

            Mi.GetTomaUnVoto(voto);


            Console.WriteLine("Votos Verdes:"+ Mi.GetvotosVerdes());
            Console.WriteLine("Votos Blancas:"+ Mi.GetvotosBlancas());
            Console.WriteLine("Votos Rosas:"+ Mi.GetvotosRosas());

            Console.WriteLine("Desea insertar otra voto?(Si/No)");
            string continuar = Console.ReadLine();

            if(continuar != "Si")
            {
                break;
            }
        }

            Console.WriteLine("El ganador fue la planilla "+ Mi.GetQuienGano()+ " votos");

    }
}


public class ConteoElectoral
{
    private int votosVerde,votosBlanca,votosRosa;

    public ConteoElectoral()
    {
        votosVerde=0;
        votosBlanca=0;
        votosRosa = 0;
    }

    public void GetTomaUnVoto(string voto)
    {
        switch(voto)
        {
            case "Verde":
            votosVerde=votosVerde+1;
            break;
            case "Blanca":
            votosBlanca=votosBlanca+1;
            break;
            case "Rosa":
            votosRosa=votosRosa+1;
            break;
            default:
            Console.WriteLine("Introduzca un voto valido");
            break;



        }
    }
    

    public int  GetvotosVerdes()
    {
        return votosVerde;
    }

    public int GetvotosBlancas()
    {
        return votosBlanca;
    }

    public int GetvotosRosas()
    {
        return votosRosa;
    }

    public string GetQuienGano()
    {
        if (votosVerde > votosBlanca && votosVerde > votosRosa)
        {
            return "Verde con "+ votosVerde;
        }
        else if (votosBlanca > votosRosa)
        {
            return "Blanca con "+ votosBlanca;
        }
        else
        {
            return "Rosa con "+ votosRosa;
        }
        
    }


}