using System;

namespace Builder
{
    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }

        public void Show()
        {
            Console.WriteLine($"CPU: {CPU}, GPU: {GPU},RAM: {RAM}, Storage:{Storage}");
        }
    }
    public interface IComputerBuilder
    {
        void SetCPU();
        void SetGPU();
        void SetRAM();
        void SetStorage();
        Computer GetComputer();
    }

    public class GamingComputer : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU()
        {
            _computer.CPU = "Intel Core i5";
        }

        public void SetGPU()
        {
            _computer.GPU = "RXT4 100";
        }

        public void SetRAM()
        {
            _computer.RAM = "8GB";
        }

        public void SetStorage()
        {
            _computer.Storage = "256GB";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
        
        
        
    }
    public class Director
    {
        public void Builder(IComputerBuilder builder)
        {
            builder.SetCPU();
            builder.SetGPU();
            builder.SetRAM();
            builder.SetStorage();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Director director = new Director();
            IComputerBuilder builder = new GamingComputer();
            director.Builder(builder);
            Computer computer = builder.GetComputer();
            computer.Show();

        }
    }
}
