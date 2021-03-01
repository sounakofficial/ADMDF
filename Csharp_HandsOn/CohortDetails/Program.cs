using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohortDetails
{
    public enum Mode
    {
        OBL,
        PARK
    }

    public enum Track
    {
        JAVA,
        DOT_NET
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("In_Order Parameter Test");
            GetCohortDetails("ADM20DF002", 21, Mode.OBL, Track.DOT_NET, "test");

            Console.WriteLine("\nOutoff_Order Parameter Test");
            GetCohortDetails("test", 21, Mode.OBL, Track.DOT_NET, "ADM20DF002");

            Console.WriteLine("\nNamed Parameter Test");
            GetCohortDetails(currentModule: "test", gencCount: 21, mode: Mode.OBL, track: Track.DOT_NET, cohortName: "ADM20DF002");

            Console.ReadLine();
        }

        public static void GetCohortDetails(string cohortName, int gencCount, Mode mode, Track track, string currentModule)
        {
            Console.WriteLine($"It is {cohortName} with {gencCount} GenCs undergoing training for {track} thru {mode}. The current module of training is {currentModule}");
        }
    }
}