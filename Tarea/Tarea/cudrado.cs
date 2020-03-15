using System;

public class cuadrado:Figura
{
    private String nombre;
    public override void nombrar(String nombre)
    {
        this.nombre =nombre;
    }
    public override void mostrarnombre()
    {
        Console.WriteLine("Yo soy la figura uno "+nombre+ " sigue la otra");
    }
}
