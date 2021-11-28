using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Trainer_Resident_Evil_4
{
    public class Cheat
    {
        public Mem m = new Mem();

        // Nop function makes the game instruction not execute on memory
        // change the ammo clip for example
        public void Nop(string adresss, string type, string byteCode) {
            m.WriteMemory(adresss, type, byteCode);
            Thread.Sleep(1000);
        }
    }
}
