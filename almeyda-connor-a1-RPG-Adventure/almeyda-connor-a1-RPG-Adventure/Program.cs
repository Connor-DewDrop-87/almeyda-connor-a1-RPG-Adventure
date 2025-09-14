// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Security.Cryptography;
// Set up
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
int time = int.Parse("0");
int weapon = 0;
int alive = 1;
int treasure = 0;
Console.WriteLine($"{name}, you're on a path in the woods. You need to get home quickly, lest the wolves find you or your food gets too cold.\nBefore you are 3 paths, one to the right, one to the left and another forward. Where do you go?");
Console.WriteLine("1) Left");
Console.WriteLine("2) Forward");
Console.WriteLine("3) Right");
int input = int.Parse(Console.ReadLine());
// First Senario Input
time++;
    if (input == 1)
    { 
    // Mushroom Room

    Console.Write("You decide to take the left path. You eventually find another fork in the road, this time going right or straight.");
    Console.WriteLine("You also notice a small patch of mushrooms. Do you take one or continue on a path?");
    Console.WriteLine("1) Eat Shroom");
    Console.WriteLine("2) Forward");
    Console.WriteLine("3) Right");
    int inputm = int.Parse(Console.ReadLine());
    if (inputm == 1)
    {
        Console.WriteLine("You decide to eat a mushroom. Your whole world shift, as psychadelic patterns begin to appear in front of you.");
        Console.WriteLine("Past nightmares manifest in reality, as you elongate stretching to infinity. Eventually everything goes dark....");
        alive = 0;
        ;
    }
    else if (inputm == 2)
    {
        time++;
        // Wolf Cave
        Console.WriteLine("Taking the straight path, you eventually find yourself next to a cave. Immediatly you hear howling from the cave. What do you do?");
        Console.WriteLine("1) Fight");
        Console.WriteLine("2) Run");
        Console.WriteLine("3) Pet");
        int inputw = int.Parse(Console.ReadLine());
        if (inputw == 1)
        {

            Console.WriteLine("You attempt to fight the wolves. Unfortunatly, you are overwhelmed. A flurry of bites of claws strike at you until eventually all you see is darkness.");
            alive = 0;
            ;
        }
        else if (inputw == 2)
            // Run Away Sequence
        {
            time++;
            time++;
            time++;
            Console.WriteLine("You attempt to run away, back to where you started and eventually to another fork in the road. Do you go left or right?");
            Console.WriteLine("1) Left");
            Console.WriteLine("2) Right");

            int inputr = int.Parse(Console.ReadLine());
            if (inputr == 1)
            {
                // Cross River
                time += 2;

                Console.WriteLine("Running to the left, you eventually find a river. Across it, you see your house down it. You've got but seconds to cross out, lest you be torn limb from limb. How do you cross it?");
                String Swim = Console.ReadLine();
                String Raft = "InflatableTube";
                bool CanCross = Swim.Contains(Raft);

                if (CanCross)
                {
                    Console.WriteLine("You cross the river using the inflatable tube, going all the way down the river. Fortunatly the wolves cannot swim and you make it back to your house.");
                    ;
                }
                else if (!CanCross)
                {
                    Console.WriteLine("You attempt to do whatever you said, but it fails. You drown or get eaten by wolves, and die");
                    alive = 0;
                    ;
                }
                ;
            }
            else if (inputr == 2)
            {
                time += 2;
                Console.WriteLine("Running to the right, you find a cave. You decide to take shelter in it, hoping to evade the wolves detection. After a few minutes, the howling stops...");
                Console.WriteLine("However, you hear another sound. A low rumbling growl. In a swift motion, you are mawled with a claw the size of your face.");

                alive = 0
                ;
            }
            ;
        }
        else if (inputw == 3)
        {
            Console.WriteLine("You attempt to pet one of the wolves, putting your hand slowly near it. The wolf then immediatly bites your hand. You scream out in pain, as the rest of the wolves attack you with a flurry of bites. Everything goes dark...");
            alive = 0;
            ;
        }
            ;
    }
    else if (inputm == 3)
    {
        // Penultimate Room of Normal Ending
        time += 1;
        Console.WriteLine("You walk to the right, going down an inclined hill. Eventually you make it to path going to the left. However, you notice a tree with a hole inside of it, along with a small patch of dirt next to it. You hear the howling of wolves in the distance behind you, and know you can only explore one before needing to go left. What do you do?");
        Console.WriteLine("1) Don't explore");
        Console.WriteLine("2) Explore Tree");
        Console.WriteLine("3) Explore Dirt");
        int inputp = int.Parse(Console.ReadLine());

        if (inputp ==2)
        {
            time += 1;
            treasure += 1;
            Console.WriteLine("You dig around in the tree hole, and find a bunch of acorns. You pocket it and continue onward");
              ;  
                }
        else if (inputp ==3)
        {
            time += 1;
            Console.WriteLine("You attempt to explore the dirt but unable to use something to dig, you struggle to get through it and eventually go left");
            ;
        }
        // Wolverine Fight
            time += 1;
        Console.WriteLine("Walking left, you see your house in the distance. However, blocking your way is a rabid wolverein. Knowing this is your only way forward before you food gets cold, you fight");
        if (weapon == 1)
        {
            time += 1;
            Console.WriteLine("Using your shovel, you bash it into the rapid wolverein, killing it. You then rush home and enjoy a nice meal.");
            ;
                }
        else { 
            Console.WriteLine("Unfortunatly, unable to defend yourself with a weapon, you are defeated by the wolverein. Killed by its flurry of claws and bites");
            alive = 0;
            ;
        } 
        
    }

}
if (input ==2)
{
    // Mine Shaft
    Console.WriteLine("Going Forward, you go down a small incline hill and find yourself in front of a mine shaft with a shovel next to it. Additionally, there's a path going down another hill.\nWhat do you do?");
    Console.WriteLine("1) Left");
    Console.WriteLine("2) Take the shovel");
    Console.WriteLine("3) Go into the shaft");
    int inputc = int.Parse(Console.ReadLine());
    if (inputc == 2) 
    {
        weapon += 1;
        treasure += 1;
        time += 1;
        Console.WriteLine("You decide to take the shovel then go left");
        ;
    }
    else if (inputc == 3)
    {
        Console.WriteLine("You decide to go into the mineshaft. It's incredibly dark, but you continue onward, until eventually you trip over a rock into a minecart, which immediatly begins to move.\nEventually a sudden flash of light happens as you are engulfed in lava.");
        alive = 0;
        time += 1;
        ;
    }
    if (inputc < 3) 
    {
        // Penultimate Room of Normal Ending
        time += 1;
        Console.WriteLine("Walking left, you go down an inclined hill. Eventually you make it to path going straight.\nHowever, you notice a tree with a hole inside of it, along with a small patch of dirt next to it.\nYou hear the howling of wolves in the distance behind you, and know you can only explore one before needing to go left. What do you do?");
        Console.WriteLine("1) Don't explore");
        Console.WriteLine("2) Explore Tree");
        Console.WriteLine("3) Explore Dirt");
        int inputp = int.Parse(Console.ReadLine());

        if (inputp == 2)
        {
            time += 1;
            treasure += 1;
            Console.WriteLine("You dig around in the tree hole, and find a bunch of acorns. You pocket it and continue onward");

            ;
        }
        else if (inputp == 3)
        {
            time += 1;
            if (weapon == 1) 
            {
                treasure += 1;
                Console.WriteLine("You dig in the dirt using your shovel and find a note which says 'InflatableTube'. What could it mean? Whatever it means, you decide to pocket it.");
                ;
            }
            if (weapon == 0)
            {
                Console.WriteLine("You attempt to explore the dirt but unable to use something to dig, you struggle to get through it and eventually go left");
                ;
            }

                ;
        }
        // Wolverine Fight
        time += 1;
        Console.WriteLine("Walking left, you see your house in the distance. However, blocking your way is a rabid wolverein. Knowing this is your only way forward before you food gets cold, you fight");
        if (weapon == 1)
        {
            time += 1;
            Console.WriteLine("Using your shovel, you bash it into the rapid wolverein, killing it. You then rush home and enjoy a nice meal.");
            ;
        }
        else
        {
            Console.WriteLine("Unfortunatly, unable to defend yourself with a weapon, you are defeated by the wolverein. Killed by its flurry of claws and bites");
            alive = 0;
            ;
        }
    }
    ;
}
if (input == 3)
{
    Console.WriteLine("Going right, you find a maple tree with two paths in between it. One way going left and the other right.");
    Console.WriteLine("1) Left");
    Console.WriteLine("2) Check the Tree then go left");
    Console.WriteLine("3) Right");
    Console.WriteLine("4) Check the Tree then go right");
    int inputmap = int.Parse(Console.ReadLine());
    if (inputmap == 2)
    {
        time += 1;
        treasure += 1;
        Console.WriteLine("You take a look behind the tree and find someone's wallet");
        ;
    }
    if (inputmap <= 2)
    {
        // Cross River
        time += 1;

        Console.WriteLine("Going to the left, you eventually find a river. Across it, you see your house down it. How do you cross it?");
        String Swim = Console.ReadLine();
        String Raft = "InflatableTube";
        bool CanCross = Swim.Contains(Raft);

        if (CanCross)
        {
            time += 1;
            Console.WriteLine("You cross the river using the inflatable tube, going all the way down the river. Fortunatly the wolves cannot swim and you make it back to your house.");
            ;
        }
        else if (!CanCross)
        {
            time += 1;
            Console.WriteLine("You attempt to do whatever you said, but it fails. You drown and die");
            alive = 0;
            ;
        }
            ;
    }
    if (inputmap==4)
    {
        treasure += 1;
        time += 1;
        Console.WriteLine("You take a look behind the tree and find someone's wallet");
        ;
    }
    if (inputmap >= 3)
    {
        time += 1;
        Console.WriteLine("Going right, you come across a cave and next to it is a bear. The bear immediatly notices you and mauls you. Everything goes dark...");
        alive = 0;
        ;
    }
    ;
}

    bool isalive = alive == 1;
bool ontime = time <= 3;
bool aliveontime = ontime && isalive;
bool alivenottime = !ontime && isalive;
if (aliveontime==true)
{
    Console.WriteLine($"You win {name} and your dinner isn't cold!"); ;
    alive = 1;
}
else if (alivenottime==true) 
{
    Console.WriteLine($"You win {name} but at what cost. Your dinner, is cold!");
    ;
    alive = 1;
}
else 
{
    Console.WriteLine($"You Lose, {name}");
    ;
}
Console.WriteLine($"Time... {time}");
Console.WriteLine($"Treasure... {treasure}");