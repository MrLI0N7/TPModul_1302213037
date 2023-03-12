using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD4_1302213037
{
    internal class DoorMachine
    {
        enum State { Terkunci, Terbuka};
        public void BukaPINTU()
        {
            State state = State.Terkunci;
            string[] screenName = { "Terkunci", "Terbuka" };
            while (state != State.Terbuka)
            {
                Console.WriteLine("Pintu sedang "+ screenName[(int)state]);
                Console.Write("Masukkan Command (BukaPintu / KunciPintu): ");

                string command = Console.ReadLine();
                switch (state)
                {
                    case State.Terkunci:
                        if (command == "KunciPintu")
                            state = State.Terkunci;
                        else if(command == "BukaPintu")
                            state = State.Terbuka;
                        else
                            state = State.Terkunci;
                        break;
                    case State.Terbuka:
                        if(command == "BukaPintu")
                            state = State.Terbuka;
                        else if(command == "KunciPintu")
                            state = State.Terkunci;
                        else
                            state = State.Terbuka;
                        break;
                }
            }
            Console.WriteLine("Status pintunya sekarang : "+state );
        }
    }
}
