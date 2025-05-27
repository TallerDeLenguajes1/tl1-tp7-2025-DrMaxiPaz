namespace EspacioCalculadora;

public class Calculadora
{
    private double dato;

    public double Resultado
    {
        get { return this.dato; }
    }

    public global::System.Double Dato { set => dato = value; }

    public void Sumar(double valor)
    {
        this.dato += valor;
    }
    public void Restar(double valor)
    {
        this.dato -= valor;
    }
    public void Multiplicar(double valor)
    {
        this.dato *= valor;
    }
    public void Dividir(double valor)
    {
        this.dato /= valor;
    }
    public void Limpiar()
    {
        this.dato = 0;
    }
}