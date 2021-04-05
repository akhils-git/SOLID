using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

    }

    interface IVehicle
    {
        string RegNo { get; set; }

        void Move();

    }

    interface ITwoWheeler : IVehicle
    {
        Handle Handle { get; set; }
        void Ride();
    }

    interface IFourWheeler : IVehicle
    {
        Steering Steering { get; set; }
        void Drive();
    }

    struct Handle
    {
        public void TurnLeft()
        {
            Console.WriteLine("Turning Left");
        }

        public void TurnRight()
        {
            Console.WriteLine("Turning Right");
        }
    }

    struct Steering
    {
        public void Rotate()
        {
            Console.WriteLine("rotating Steering..");
        }
    }

    class Benz : IFourWheeler
    {
        public Steering Steering { get; set; } = new Steering();
        public string RegNo { get; set; } = "KL001";

        public void Drive()
        {
            this.Steering.Rotate();
            Console.WriteLine("Benz Driving....");
        }

        public void Move()
        {
            Drive();
        }
    }

    class Audi : IFourWheeler
    {
        public Steering Steering { get; set; } = new Steering();
        public string RegNo { get; set; } = "KL002";

        public void Drive()
        {
            this.Steering.Rotate();
            Console.WriteLine("Audi Driving....");
        }

        public void Move()
        {
            Drive();
        }
    }

    class Pulsar : ITwoWheeler
    {
        public Handle Handle { get; set; } = new Handle();
        public string RegNo { get; set; } = "KL003";

        public void Move()
        {
            Ride();
        }

        public void Ride()
        {
            this.Handle.TurnLeft();
            Console.WriteLine("Pulsar Riding...");
        }
    }
}
