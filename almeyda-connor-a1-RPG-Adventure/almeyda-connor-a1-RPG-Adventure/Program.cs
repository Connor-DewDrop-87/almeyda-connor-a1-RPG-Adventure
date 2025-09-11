// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("You're on a path in the woods. You need to get home quickly, lest the wolves find you or your food gets too cold. Before you are 3 paths, one to the right, one to the left and another forward. Where do you go?");
Console.WriteLine("1) Left");
Console.WriteLine("2) Forward");
Console.WriteLine("3) Right");
int time = 0;
int input = int.Parse(Console.ReadLine());
int alive = 1;

// First Senario Input
time++;
{ 
if (input == 1) ;
    Console.Write("You decide to take the left path. You eventually find another fork in the road, this time going right or straight.");
Console.WriteLine("You also notice a small patch of mushrooms. Do you take one or continue on a path?");
Console.WriteLine("1) Eat Shroom");
Console.WriteLine("2) Forward");
Console.WriteLine("3) Right");
int input2= int.Parse(Console.ReadLine());
    if (input2== 1) ;
Console.WriteLine("You decide to eat a mushroom. Your whole world shift, as psychadelic patterns begin to appear in front of you. Past nightmares manifest in reality, as you elongate stretching to infinity. Eventually everything goes dark, and you die");
Console.WriteLine("Past nightmares manifest in reality, as you elongate stretching to infinity. Eventually everything goes dark....");
if (input2 == 2) ;
    time++;
    Console.WriteLine("Taking the straight path, you eventually find yourself next to a cave. Immediatly you hear howling from the cave. What do you do?");


}
alive = 0;
bool isdead = alive == 0;
bool isalive = !isdead;

if (isdead = true) ;
Console.WriteLine("You Lose");
