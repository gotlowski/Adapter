using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var adapter = new LionAdapter(new Wolf());
            adapter.Roar();

        }
    }

    class Lion : ITarget
    {
        public void Roar()
        {
            Console.WriteLine("wrrrr!");
        }
    }

    internal interface ITarget
    {
        public void Roar();
    }

    class Wolf
    {
        public void Howl()
        {
            Console.WriteLine("aauuuu");
        }
    }

    class LionAdapter : ITarget
    {
        private Wolf wolf;
        public LionAdapter(Wolf wolf)
        {
            this.wolf = wolf;
        }
        public void Roar()
        {
            wolf.Howl();
        }
    }

}
