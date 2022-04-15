using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House("brick", 12);
            IPrototype clonedHouse = house.Clone();
            house.GetInfo();
            clonedHouse.GetInfo();
        }
    }

    interface IPrototype
    {
        IPrototype Clone();
        void GetInfo();
    }

    class House : IPrototype
    {
        string material;
        int floors;
        public House(string material, int floors)
        {
           this.material=material;
            this.floors = floors;
        }

        public IPrototype Clone()
        {
            return new House(this.material, this.floors);
        }
        public void GetInfo()
        {
            Console.WriteLine("House - {0}, floors - {1}", material, floors);
        }
    }
}
