using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Animal_Noises
{
    public class Animal
    {
        private SoundPlayer soundPlayer;
        private String sharedLockString;

        public Animal(String soundFileName, string sharedLockString)
        {
            soundPlayer = new SoundPlayer(soundFileName);
            // Grab the lock object (string in this case) out of our constructor
            this.sharedLockString = sharedLockString;   // assign to our local string
        }

        public void speak()
        {
                while (true)
                {
                    // Don't execude code block unless you have the lock on sharedLockString
                    lock (sharedLockString)
                    {
                        soundPlayer.Play();
                        Thread.Sleep(500);
                    }
                }
        }

    }
}
