using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchLab1
{
    public class Vote
    {
        
        Random rand = new Random();
        int countMembers = Enum.GetValues(typeof(Members)).Length;
        public void memberVote(int votingCount1, int votingCount2, int votingCount3, int votingCount4, int votingCount5)
        {
            for(int i = 1; i < countMembers; i++)
            {
                Console.WriteLine("Which Movie will you Vote For?");
                Console.WriteLine(" StarWars = 1, Inception = 2, LordofTheRings = 3, Avengers = 4, TheDarkNight = 5" );
                string voterInput = Console.ReadLine();
                int number;
                if(Int32.TryParse(voterInput, out number))
                {
                //int num = rand.Next(1,6);
                switch (number)
                {
                    case 1:
                            Console.WriteLine("Voted for Star Wars.");
                        votingCount1++;
                        break;
                    case 2:
                            Console.WriteLine("Voted for Inception.");
                            votingCount2++;
                        break;
                    case 3:
                            Console.WriteLine("Voted for Lord of the Rings.");
                            votingCount3++;
                        break;
                    case 4:
                            Console.WriteLine("Voted for Avengers.");
                            votingCount4++;
                        break;
                    default:
                            Console.WriteLine("Voted for The Dark Knight.");
                            votingCount5++;
                        break;

                }

                }
            }
                        Console.WriteLine("Star Wars got " + votingCount1 + " votes.");
                        Console.WriteLine("Inception got " + votingCount2 + " votes.");
                        Console.WriteLine("Lord of the Rings got " + votingCount3 + " votes.");
                        Console.WriteLine("Avengers got " + votingCount4 + " votes.");
                        Console.WriteLine("The Dark Knight got " + votingCount5 + " votes.");
        }

    }
}
