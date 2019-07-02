using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Bird bird = new Bird();
            bird.Move(); //Birds Fly
           

            Penguin penguin = new Penguin();
            penguin.Move(); //  Penguins Waddle

            Bird penguinBird = new Penguin();
            penguinBird.Move();


        }
    }

    

    

}
