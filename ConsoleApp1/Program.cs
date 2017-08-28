using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Beep
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------
            //--- edit-vshome branch pls ---
            //------------------------------

            char auswahl;
            bool quit = false;

            while (quit == false)
            { 
            Console.WriteLine("Let the Beep Boop fall!\nWähle zwischen verschiedenen Songs aus! \n\n1) Tetris Main Theme \n2) Beverly Hills Cop\n3) Deutsche Nationalhymne\n\n0) Beenden");
            auswahl = Convert.ToChar(Console.ReadKey().KeyChar);

                switch (auswahl)
                {
                    case '0':
                        quit = true;
                        break;
                    case '1':
                        //Tetris
                        Console.Clear();
                        Console.WriteLine("Playing: Tetris Main Theme");
                        Console.Beep(1320, 500);
                        Console.Beep(990, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(1188, 250);
                        Console.Beep(1320, 125);
                        Console.Beep(1188, 125);
                        Console.Beep(1056, 250);
                        Console.Beep(990, 250);
                        Console.Beep(880, 500);
                        Console.Beep(880, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(1320, 500);
                        Console.Beep(1188, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(990, 750);
                        Console.Beep(1056, 250);
                        Console.Beep(1188, 500);
                        Console.Beep(1320, 500);
                        Console.Beep(1056, 500);
                        Console.Beep(880, 500);
                        Console.Beep(880, 500);
                        Thread.Sleep(500);
                        Console.Beep(1188, 500);
                        Console.Beep(1408, 250);
                        Console.Beep(1760, 500);
                        Console.Beep(1584, 250);
                        Console.Beep(1408, 250);
                        Console.Beep(1320, 750);
                        Console.Beep(1056, 250);
                        Console.Beep(1320, 500);
                        Console.Beep(1188, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(990, 500);
                        Console.Beep(990, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(1188, 500);
                        Console.Beep(1320, 500);
                        Console.Beep(1056, 500);
                        Console.Beep(880, 500);
                        Console.Beep(880, 500);
                        Thread.Sleep(1000);
                        Console.Beep(1320, 500);
                        Console.Beep(990, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(1188, 250);
                        Console.Beep(1320, 125);
                        Console.Beep(1188, 125);
                        Console.Beep(1056, 250);
                        Console.Beep(990, 250);
                        Console.Beep(880, 500);
                        Console.Beep(880, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(1320, 500);
                        Console.Beep(1188, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(990, 750);
                        Console.Beep(1056, 250);
                        Console.Beep(1188, 500);
                        Console.Beep(1320, 500);
                        Console.Beep(1056, 500);
                        Console.Beep(880, 500);
                        Console.Beep(880, 500);
                        Thread.Sleep(500);
                        Console.Beep(1188, 500);
                        Console.Beep(1408, 250);
                        Console.Beep(1760, 500);
                        Console.Beep(1584, 250);
                        Console.Beep(1408, 250);
                        Console.Beep(1320, 750);
                        Console.Beep(1056, 250);
                        Console.Beep(1320, 500);
                        Console.Beep(1188, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(990, 500);
                        Console.Beep(990, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(1188, 500);
                        Console.Beep(1320, 500);
                        Console.Beep(1056, 500);
                        Console.Beep(880, 500);
                        Console.Beep(880, 500);
                        Thread.Sleep(500);
                        Console.Beep(660, 1000);
                        Console.Beep(528, 1000);
                        Console.Beep(594, 1000);
                        Console.Beep(495, 1000);
                        Console.Beep(528, 1000);
                        Console.Beep(440, 1000);
                        Console.Beep(419, 1000);
                        Console.Beep(495, 1000);
                        Console.Beep(660, 1000);
                        Console.Beep(528, 1000);
                        Console.Beep(594, 1000);
                        Console.Beep(495, 1000);
                        Console.Beep(528, 500);
                        Console.Beep(660, 500);
                        Console.Beep(880, 1000);
                        Console.Beep(838, 2000);
                        Console.Beep(660, 1000);
                        Console.Beep(528, 1000);
                        Console.Beep(594, 1000);
                        Console.Beep(495, 1000);
                        Console.Beep(528, 1000);
                        Console.Beep(440, 1000);
                        Console.Beep(419, 1000);
                        Console.Beep(495, 1000);
                        Console.Beep(660, 1000);
                        Console.Beep(528, 1000);
                        Console.Beep(594, 1000);
                        Console.Beep(495, 1000);
                        Console.Beep(528, 500);
                        Console.Beep(660, 500);
                        Console.Beep(880, 1000);
                        Console.Beep(838, 2000);
                        Console.Clear();
                        break;
                    case '2':
                        //Beverly Hills Cop
                        Console.Clear();
                        Console.WriteLine("Playing: Beverly Hills Cop");
                        Console.Beep(676, 460);
                        Console.Beep(804, 340);
                        Console.Beep(676, 230);
                        Console.Beep(676, 110);
                        Console.Beep(902, 230);
                        Console.Beep(676, 230);
                        Console.Beep(602, 230);
                        Console.Beep(676, 460);
                        Console.Beep(1012, 340);
                        Console.Beep(676, 230);
                        Console.Beep(676, 110);
                        Console.Beep(1071, 230);
                        Console.Beep(1012, 230);
                        Console.Beep(804, 230);
                        Console.Beep(676, 230);
                        Console.Beep(1012, 230);
                        Console.Beep(1351, 230);
                        Console.Beep(676, 110);
                        Console.Beep(602, 230);
                        Console.Beep(602, 110);
                        Console.Beep(506, 230);
                        Console.Beep(758, 230);
                        Console.Beep(676, 980);
                        Console.Clear();
                        break;
                    case '3':
                        //Nationalhymne
                        Console.Clear();
                        Console.WriteLine("Playing: Deutsche Nationalhymne");
                        Console.Beep(704, 750);
                        Console.Beep(792, 250);
                        Console.Beep(880, 500);
                        Console.Beep(792, 500);
                        Console.Beep(940, 500);
                        Console.Beep(880, 500);
                        Console.Beep(792, 250);
                        Console.Beep(660, 250);
                        Console.Beep(704, 500);
                        Console.Beep(1188, 500);
                        Console.Beep(1056, 500);
                        Console.Beep(940, 500);
                        Console.Beep(880, 500);
                        Console.Beep(792, 500);
                        Console.Beep(880, 250);
                        Console.Beep(704, 250);
                        Console.Beep(1056, 1000);
                        Console.Beep(704, 750);
                        Console.Beep(792, 250);
                        Console.Beep(880, 500);
                        Console.Beep(792, 500);
                        Console.Beep(940, 500);
                        Console.Beep(880, 500);
                        Console.Beep(792, 250);
                        Console.Beep(660, 250);
                        Console.Beep(704, 500);
                        Console.Beep(1188, 500);
                        Console.Beep(1056, 500);
                        Console.Beep(940, 500);
                        Console.Beep(880, 500);
                        Console.Beep(792, 500);
                        Console.Beep(880, 250);
                        Console.Beep(704, 250);
                        Console.Beep(1056, 1000);
                        Console.Beep(792, 500);
                        Console.Beep(880, 500);
                        Console.Beep(792, 250);
                        Console.Beep(660, 250);
                        Console.Beep(528, 500);
                        Console.Beep(940, 500);
                        Console.Beep(880, 500);
                        Console.Beep(792, 250);
                        Console.Beep(660, 250);
                        Console.Beep(528, 500);
                        Console.Beep(1056, 500);
                        Console.Beep(940, 500);
                        Console.Beep(880, 750);
                        Console.Beep(880, 250);
                        Console.Beep(990, 500);
                        Console.Beep(940, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(1056, 1000);
                        Console.Beep(1408, 750);
                        Console.Beep(1320, 250);
                        Console.Beep(1320, 250);
                        Console.Beep(1188, 250);
                        Console.Beep(1056, 500);
                        Console.Beep(1188, 750);
                        Console.Beep(1056, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(940, 250);
                        Console.Beep(880, 500);
                        Console.Beep(792, 750);
                        Console.Beep(880, 125);
                        Console.Beep(940, 125);
                        Console.Beep(1056, 250);
                        Console.Beep(1188, 250);
                        Console.Beep(940, 250);
                        Console.Beep(792, 250);
                        Console.Beep(704, 500);
                        Console.Beep(880, 250);
                        Console.Beep(792, 250);
                        Console.Beep(704, 1000);
                        Console.Beep(1408, 750);
                        Console.Beep(1320, 250);
                        Console.Beep(1320, 250);
                        Console.Beep(1188, 250);
                        Console.Beep(1056, 500);
                        Console.Beep(1188, 750);
                        Console.Beep(1056, 250);
                        Console.Beep(1056, 250);
                        Console.Beep(940, 250);
                        Console.Beep(880, 500);
                        Console.Beep(792, 750);
                        Console.Beep(880, 125);
                        Console.Beep(940, 125);
                        Console.Beep(1056, 250);
                        Console.Beep(1188, 250);
                        Console.Beep(940, 250);
                        Console.Beep(792, 250);
                        Console.Beep(704, 500);
                        Console.Beep(880, 250);
                        Console.Beep(792, 250);
                        Console.Beep(704, 1000);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
