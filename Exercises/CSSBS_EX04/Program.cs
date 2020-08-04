using System;

namespace animalFarm.sql
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig();
            Horse();
            Goat();
            Chicken();
        }
        private static void Pig()
        {
            Pig pigLet = new Pig("Piglet");
            pigLet.Speak();
            pigLet.Eat();
            pigLet.Produce();
            pigLet.Move();

            Pig olivia = new Pig("Olivia");
            olivia.Speak();
            olivia.Eat();
            olivia.Produce();
            olivia.Move();

            Pig pumbaa = new Pig("Pumbaa");
            pumbaa.Speak();
            pumbaa.Eat();
            pumbaa.Produce();
            pumbaa.Move();

            Pig babe = new Pig("Babe");
            babe.Speak();
            babe.Eat();
            babe.Produce();
            babe.Move();
        }
        private static void Horse()
        {
            Horse mustang = new Horse("Mustang");
            mustang.Speak();
            mustang.Eat();
            mustang.Produce();
            mustang.Move();

            Horse hampton = new Horse("Hamton");
            hampton.Speak();
            hampton.Eat();
            hampton.Produce();
            hampton.Move();

            Horse loneRanger = new Horse("Lone Ranger");
            loneRanger.Speak();
            loneRanger.Eat();
            loneRanger.Produce();
            loneRanger.Move();

            Horse comet = new Horse("Comet");
            comet.Speak();
            comet.Eat();
            comet.Produce();
            comet.Move();
        }
        private static void Goat()
        {
            Goat clueless = new Goat("Clueless");
            clueless.Speak();
            clueless.Eat();
            clueless.Produce();
            clueless.Move();

            Goat jeb = new Goat("Jeb");
            jeb.Speak();
            jeb.Eat();
            jeb.Produce();
            jeb.Move();

            Goat pleasant = new Goat("Pleasant");
            pleasant.Speak();
            pleasant.Eat();
            pleasant.Produce();
            pleasant.Move();

            Goat billy = new Goat("Billy");
            billy.Speak();
            billy.Eat();
            billy.Produce();
            billy.Move();
        }
        private static void Chicken()
        {
            Chicken ernie = new Chicken("Ernie");
            ernie.Speak();
            ernie.Eat();
            ernie.Produce();
            ernie.Move();

            Chicken gyro = new Chicken("Gyro");
            gyro.Speak();
            gyro.Eat();
            gyro.Produce();
            gyro.Move();

            Chicken missPrissy = new Chicken("Miss Prissy");
            missPrissy.Speak();
            missPrissy.Eat();
            missPrissy.Produce();
            missPrissy.Move();

            Chicken buckCluck = new Chicken("Buck Cluck");
            buckCluck.Speak();
            buckCluck.Eat();
            buckCluck.Produce();
            buckCluck.Move();
        }
    }
}


