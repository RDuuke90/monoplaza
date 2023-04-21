namespace Monoplaza.src;

public abstract class AbsMonoplaza : IMonoplaza
{
    protected bool start = false;
    protected bool move = false;

    public void apagar()
    {
        if (this.start) {
            Console.WriteLine("Monoplaza apagado!");
            this.start = !this.start;
        } else {
            Console.WriteLine("Monoplaza ya esta apagado");
        }
    }

    public void detener()
    {
         if (this.start && this.move) {
            Console.WriteLine("Monoplaza ya esta detenido!");
            this.move = !this.move;
       } else {
            Console.WriteLine("Monoplaza ya estava detenido o estaba apagando!");
       }
    }

    public void encender()
    {
         if (! this.start) {
            Console.WriteLine("Monoplaza encendido!");
            this.start = !this.start;
        } else {
            Console.WriteLine("Monoplaza ya esta encendido");
        }
    }

    public void movimiento()
    {
       if (this.start && !this.move) {
            Console.WriteLine("Monoplaza esta en movimiento!");
            this.move = !this.move;
       } else {
            Console.WriteLine("Monoplaza ya estava moviendose o estaba apagando!");
       }
    }
}