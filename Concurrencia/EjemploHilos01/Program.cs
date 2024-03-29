﻿// Escenario de subprocesamiento simple:
// iniciar un método estático en ejecución en un segundo hilo
static void ThreadProc()
{
    // Se llama al método ThreadProc cuando se inicia el subproceso.
    // Hace un bucle diez veces, escribe en la consola y produce
    // el resto de su intervalo de tiempo cada vez, y luego termina.
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("ThreadProc: {0}", i);
        Thread.Sleep(0);
    }
}

Console.WriteLine("Subproceso principal: iniciar un segundo subproceso");
// El constructor de la clase Thread requiere un ThreadStart
// delegado que presenta el método a ejecutar en el
// hilo. C# simplifica la creación de este delegado
Thread t = new Thread(new ThreadStart(ThreadProc));

// Iniciar ThreadProc. Tenga en cuenta que en un monoprocesador, el nuevo
// hilo no obtiene ningún tiempo de procesador hasta que el hilo principal
// es reemplezado o cede. Descomente el Thread.Sleep que
// sigue a t.Start() para ver la diferencia.
t.Start();
//Thread.Sleep(0);

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Hilo principal: Trabaja un poco.");
    Thread.Sleep(0);
}

Console.WriteLine("Subproceso principal: Llamar a Join(), para esperar " +
    "hasta que finalice ThreadProc.");
t.Join();
Console.WriteLine("Subproceso principal: ThreadProc.Join ha regresado. " +
    "Presiona Enter para finalizar el programa.");
Console.ReadLine();