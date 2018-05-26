using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playtime
{
    public enum Emotion
    {
        SAD,
        HAPPY,
        ANGRY,
        DEPRESSED,
    }

    public class Person
    {
        public Person()
        {
            _age = 0;
            _name = "Rowan";
            _emotion = Emotion.SAD;
        }

        public string _name { get; set; }
        public int _age { get; set; }
        public Emotion _emotion { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person row = new Person();
            while (row._emotion != Emotion.HAPPY)
            {
                StateLoop(row);
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }

        public static Emotion StateLoop(Person person)
        {
            Random rand = new Random();
            person._age++;
            var biLuck = rand.Next(0, 100);
            switch (person._emotion)
            {
                case Emotion.SAD:
                    {
                        if (biLuck < 20)
                            person._emotion = Emotion.DEPRESSED;
                        else if (biLuck < 60)
                            person._emotion = Emotion.ANGRY;
                        else
                            person._emotion = Emotion.HAPPY;
                        break;
                    }
                case Emotion.DEPRESSED:
                    {
                        if (biLuck < 20)
                            person._emotion = Emotion.SAD;
                        else if (biLuck < 60)
                            person._emotion = Emotion.ANGRY;
                        else
                            person._emotion = Emotion.HAPPY;
                        break;
                    }
                case Emotion.ANGRY:
                    {
                        if (biLuck < 20)
                            person._emotion = Emotion.SAD;
                        else if (biLuck < 70)
                            person._emotion = Emotion.DEPRESSED;
                        else
                            person._emotion = Emotion.HAPPY;
                        break;
                    }
                case Emotion.HAPPY:
                    {
                        break;
                    }
            }
            Console.WriteLine("Person by the name of " + person._name + " at age " + person._age + " is " + person._emotion);
            return person._emotion;
        }
    }
}
