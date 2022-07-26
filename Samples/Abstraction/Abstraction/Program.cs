﻿using System;

namespace MyApplication
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }

    class Pig : Animal
    {
        public override void animalSound()
        {
            
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  
            myPig.animalSound();
            myPig.sleep();
        }
    }
}