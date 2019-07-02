using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRussian
{
    class gun
        //gun is the class of GameRussian which is display below
    {
        public int loadbullete;
        
        public int winscore;
        public int bullets = 2;
        public int gunshoot = 0;
        public int Spinload;
        
        public int ko;



        Random objran = new Random();

        public int Spined { get; internal set; }

        public void try_again()
        {
            gunshoot = 0;
        }
        public int gunspin()
        {
            Spinload = objran.Next(1, 7);
            return Spinload;
        }



        public int fire(int bullete, int bulspin)
        {


            if (gunshoot == 0 && bullete == Spinload)
            {
                gunshoot = 3;
                winscore = 10;
            }
            else if (gunshoot == 1 && bullete != Spinload)
            {
                winscore = 0;
            }

            else if (gunshoot == 1 && bullete == Spinload)
            {
                gunshoot = 3;
                winscore = 5;
            }
            if (Spinload == 2)
            {
                ko = 2;

            }
            if (Spinload == 1)
            {
                ko = 1;

            }
            else
            {
                gunshoot++;
                

            }



            return winscore;
        }
        public int bulletespin(int spin)
        {
            if (spin == 6)
            {
                spin = 1;

            }
            else
            {
                spin++;

            }
            return spin;

        }

    }
}
