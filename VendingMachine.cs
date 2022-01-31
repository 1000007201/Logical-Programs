using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class VendingMachine
    {
        public void NoteCounter()
        {
            Console.WriteLine("Enter Your Amount:");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] note_counter = new int[9];
            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    note_counter[i] = amount / notes[i];
                    amount -= notes[i]*note_counter[i];
                }
            }
            for (int i = 0; i < note_counter.Length; i++)
            {
                if (note_counter[i] > 0)
                {
                    Console.WriteLine(notes[i] + ":" + note_counter[i]);
                }
            }
        }
    }
}
