using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace RussianShoot
{
   public class Classshoot
    {
       // class variables
        int[] bullet = {0,0,0,0,0,0};
        string notify;

        // soundplayer for diff kind of sound for each button
        SoundPlayer loadgun = new SoundPlayer(Properties.Resources.loadgun);
       
        SoundPlayer spin = new SoundPlayer(Properties.Resources.spin);
       // load bullet
        public string  loadbullet(int bullets,out int mybullet,out int life)
        {
            bullet[0] = 1;
            bullets = 1;
            life = 2;
            mybullet = bullets;
            notify = "Bullet is loaded";

            loadgun.Play();
            return notify; // retun value as result and notification for each action
        }
        // spinshot for random rumber
        public string spinshot(out int myrandom)
        {

                Random luck = new Random();// random function
                 myrandom= luck.Next(0, 6);

                if (myrandom != 0)
            {
                bullet[0] = 0;
                bullet[myrandom] = 1;
            }

                myrandom++;

            
            notify = "Spinning....Spinning....Spinning";

            spin.Play();
            return notify;
            
        }
     
    }
}
