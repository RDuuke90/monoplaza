using Monoplaza.src;

F1 ferrari = new F1("ferrari");
F1 mclaren = new F1("mclaren");
F1 redbull = new F1("redbull");

int[] table = new int[3];

F1[] grid_f1 = new F1[]{ferrari, mclaren, redbull};
Circuit circuit = new Circuit("Monaco", 3);

for(int i = 0; i < grid_f1.Length; i++) {

    Console.WriteLine("Inicia la prueba de: "+grid_f1[i].team);
    circuit.AddMonoplaza(grid_f1[i]);
    table[i] = circuit.Start();
    circuit.RemoveMonoplaza();
    Console.WriteLine("finaliza la prueba de: "+grid_f1[i].team);
}

Array.Sort(table);

Console.WriteLine("Tabla de posiciones:");
foreach(int number in table)
{
    Console.WriteLine($"Tiempo de vuelta:{number}");
}