// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Security.Cryptography;

Console.WriteLine("You're on a path in the woods. You need to get home quickly, lest the wolves find you or your food gets too cold. Before you are 3 paths, one to the right, one to the left and another forward. Where do you go?");
Console.WriteLine("1) Left");
Console.WriteLine("2) Forward");
Console.WriteLine("3) Right");
int time = int.Parse("0");
int input = int.Parse(Console.ReadLine());
int alive = 1;

// First Senario Input
time++;
{
    {
        if (input == 1) ;
        // Mushroom Room
        { Console.Write("You decide to take the left path. You eventually find another fork in the road, this time going right or straight.");
        Console.WriteLine("You also notice a small patch of mushrooms. Do you take one or continue on a path?");
        Console.WriteLine("1) Eat Shroom");
        Console.WriteLine("2) Forward");
        Console.WriteLine("3) Right");
        int inputm = int.Parse(Console.ReadLine());
        
            {
                if (inputm == 1) ;
                Console.WriteLine("You decide to eat a mushroom. Your whole world shift, as psychadelic patterns begin to appear in front of you.");
                Console.WriteLine("Past nightmares manifest in reality, as you elongate stretching to infinity. Eventually everything goes dark....");
                alive = 0;
            }
            { if (inputm == 2) ;
            time++;

            // Wolf Cave
            Console.WriteLine("Taking the straight path, you eventually find yourself next to a cave. Immediatly you hear howling from the cave. What do you do?");
            Console.WriteLine("1) Fight");
            Console.WriteLine("2) Run");
            Console.WriteLine("3) Pet");
            int inputw = int.Parse(Console.ReadLine());
            {
                if (inputw == 1) ;

                Console.WriteLine("You attempt to fight the wolves. Unfortunatly, you are overwhelmed. A flurry of bites of claws strike at you until eventually all you see is darkness.");
                alive = 0;
            }
            {
                if (inputw == 2) ;
                time++;
                time++;
                time++;
                Console.WriteLine("You attempt to run away, back to where you started and eventually to another fork in the road. Do you go left or right?");
                Console.WriteLine("1) Left");
                Console.WriteLine("2) Right");
                int inputr = int.Parse(Console.ReadLine());

                    {
                        if (inputr == 1) ;
                        time++;
                        time++;
                        Console.WriteLine("Running to the left, you eventually find a river. Across it, you see your house down it.");
                        Console.WriteLine("You've got but seconds to cross out, lest you be torn limb from limb. How do you cross it?");

                        // Cross River
                        String Swim = Console.ReadLine();
                        String Raft = "InflatableTube";
                        bool CanCross = Swim.Contains(Raft);
                        {
                            {
                                if (CanCross) ;
                                Console.WriteLine("You cross the river using the inflatable tube, going all the way down the river. Fortunatly the wolves cannot swim and you make it back to your house.");
                            }
                            {
                                if (!CanCross) ;
                                Console.WriteLine("You attempt to do whatever you said, but it fails. You drown, get eaten by wolves, and die");
                                alive = 0;
                            }

                        }

                        {

                        }
                    }
                    
    
               
                        
                    
                }
                
            }
        }

    }

    bool isdead = alive == 0;
    bool isalive = !isdead;
    bool ontime = time <= 3;
    bool aliveontime = ontime && isalive;
    bool alivenottime = !ontime && isalive;

    if (isdead = true) ;
    Console.WriteLine("You Lose");
    if (aliveontime) ;
    Console.WriteLine("You win and your dinner isn't cold!");
    if (alivenottime) ;
    Console.WriteLine("You win but at what cost. Your dinner isn't cold!");
    Console.WriteLine($"Time... {time}");
}
