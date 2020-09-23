using System;
using System.IO;

namespace Drofsnar_Challenge
{
    class Program
    {
        // Default folder    
        static readonly string rootFolder = @"C:\ElevenFiftyProjects\Gold Badge\Drofsnar challenge";
        //Default file. 
        static readonly string textFile = @"C:\ElevenFiftyProjects\Gold Badge\Drofsnar challenge\game-sequence.txt";


        static void Main(string[] args)
        {


            if (File.Exists(textFile))
            {
                //Read file using StreamReader. Reads file line by line  
                using (StreamReader file = new StreamReader(textFile))
                {
                    //int counter = 0;
                    //string line;
                    double points = 5000;
                    int VulnerableBirdHunterPointsFactor = 0;
                    int lives = 3;
                    bool receivedBonus = false;

                    string readText = File.ReadAllText(textFile);
                    //Console.WriteLine(readText);

                    string[] birds = readText.Split(",");


                    foreach (string bird in birds)
                    {
                        
                        if (lives > 0)
                        {
                            Console.WriteLine(bird);

                            if (bird.Equals("Bird"))
                            {
                                points += 10;
                            }
                            if (bird.Equals("CrestedIbis"))
                            {
                                points += 100;
                            }
                            if (bird.Equals("GreatKiskudee"))
                            {
                                points += 300;
                            }
                            if (bird.Equals("RedCrossbill"))
                            {
                                points += 500;
                            }
                            if (bird.Equals("Red-neckedPhalarope"))
                            {
                                points += 700;
                            }
                            if (bird.Equals("EveningGrosbeak"))
                            {
                                points += 1000;
                            }
                            if (bird.Equals("GreaterPrairieChicken"))
                            {
                                points += 2000;
                            }
                            if (bird.Equals("IcelandGull"))
                            {
                                points += 3000;
                            }
                            if (bird.Equals("Orange-belliedParrot"))
                            {
                                points += 5000;
                            }
                            if (bird.Equals("VulnerableBirdHunter"))
                            {
                                VulnerableBirdHunterPointsFactor++;
                                points += 100 * (Math.Pow(2, VulnerableBirdHunterPointsFactor));
                            }
                            if (bird.Equals("InvincibleBirdHunter"))
                            {
                                lives -= 1;
                            }

                            if (receivedBonus == false && points > 10000)
                            {
                                lives++;
                                receivedBonus = true;
                            }

                            Console.WriteLine("points" + " " + points);
                        }
                        else
                        {
                            Console.WriteLine("You're dead.");
                            break;
                        }
                    }
                    file.Close();
                    Console.WriteLine($"Drofsnar has {points} points. \n" + $"Drofsnar has {lives} lives left.");
                    //Console.WriteLine($"File has {counter} lines.");
                    Console.ReadKey();
                }

            }
        }
    }
    }


