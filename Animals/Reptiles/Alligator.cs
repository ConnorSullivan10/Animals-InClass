using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Reptiles
{
    internal class Alligator
    {
        // internal: I am only accessible inside this project

        public bool IsAquatic { get; set; }
        //underscore typically indicates a field which is intended to be private, as opposed to a property
        private int _stepGoal;
        private int _stepCount;

        public Alligator(int stepGoal)
        {
            IsAquatic = true;
            _stepGoal = stepGoal;
        }

        public void Grunt()
        {
            if (IsAquatic)
            {
                Console.WriteLine("Bubble Bubble");
            }
            else
            {
                Console.WriteLine("GRRRRR!");
            }
        }

        public void Run(int steps)
        {
            _stepCount += steps;

            Console.WriteLine($"You ran { steps} steps");

            if (steps >= _stepGoal)
            {
                Console.WriteLine("Congratulations, you achieved your goal!!!!!!!!!!");
            }
        }
    }
}
