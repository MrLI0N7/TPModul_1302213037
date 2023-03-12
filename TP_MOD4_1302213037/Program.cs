// See https://aka.ms/new-console-template for more information
using TP_MOD4_1302213037;

internal class Program
{
    public static void Main(String[] args)
    {
        // Soal 1 Table-Driven
        KodePos TablePos = new KodePos();
        KodePos.Kelurahan kelurahan = KodePos.Kelurahan.Maleer;
        int kodePos = TablePos.getKodePos(kelurahan);
        Console.WriteLine("KodePos dari kelurahan " + kelurahan + " adalah " + kodePos);

        // Soal 2 State-Base
        Console.WriteLine();
        DoorMachine PINTU = new DoorMachine();
        PINTU.BukaPINTU();

    }
}