namespace Monoplaza.src;


public class Circuit 
{
    protected string name;
    protected int number_of_turns;

    protected Random rand = new Random();


    protected IMonoplaza? monoplaza;

    public Circuit(string name, int number_of_turns)
    {
        this.name = name;
        this.number_of_turns = number_of_turns;
    }

    public int Start()
    {
        int best_time = 9999999;

        this.monoplaza?.encender();
        this.monoplaza?.movimiento();

        for(int i = 0; i < this.number_of_turns; i++) {
            int turn = rand.Next(100000, 999999);
            if (best_time > turn) {
                best_time = turn;
                continue;
            }
        }
        Console.WriteLine($"Mejor vuelta {best_time}");
        this.monoplaza?.detener();
        this.monoplaza?.apagar();

        return best_time;
    }
    public void AddMonoplaza(IMonoplaza monoplaza)
    {
        if (this.monoplaza == null) {
            this.monoplaza = monoplaza;
        } else {
            Console.WriteLine("Ya hay un monoplaza en el circuito");
        }
    }

     public void RemoveMonoplaza()
    {
        if (this.monoplaza != null) {
            this.monoplaza = null;
        } else {
            Console.WriteLine("No hay un monoplaza en el circuito");
        }
    }
}