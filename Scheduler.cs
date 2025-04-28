using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmos
{
    internal class Scheduler
    {
        public void months()
        {
            Schedule[][] month = new Schedule[12][];

            month[0] = new Schedule[31];
            month[1] = new Schedule[28];
            month[2] = new Schedule[31];
            month[3] = new Schedule[30];
            month[4] = new Schedule[31];
            month[5] = new Schedule[30];
            month[6] = new Schedule[31];
            month[7] = new Schedule[31];
            month[8] = new Schedule[30];
            month[9] = new Schedule[31];
            month[10] = new Schedule[30];
            month[11] = new Schedule[31];

            for (int i = 0; i < month.Length; i++)
            {
                Console.WriteLine("El mes "+ (i+1) + " tiene " + month[i].Length + " días.");
            }
        }
    }

    public class Schedule
    {
        public string Task { get; set; }
        public Schedule Next { get; set; }
    }
}
