using System;

class Power
{
    public void TurnOn()
    {
        Console.WriteLine("Питание включено");
    }
}
class CPU
{
    public void Start()
    {
        Console.WriteLine("Процессор запущен");
    }
}
class Memory
{
    public void Load()
    {
        Console.WriteLine("Память загружена");
    }
}
class HDD
{
    public void Load()
    {
        Console.WriteLine("Данные с диска загружены!");
    }
}

class Computer
{
    private Power power;
    private CPU cpu;
    private Memory memory;
    private HDD hdd;
    
    public Computer()
    {
        power = new Power();
        cpu = new CPU();
        memory = new Memory();
        hdd = new HDD();
    }

    public void Start()
    {
        power.TurnOn();
        cpu.Start();
        memory.Load();
        hdd.Load();

        Console.WriteLine("Все загрузилось !!!!!!!!!");
    }

}
class Program
{
    static void Main()
    {
        Computer computer = new Computer();

        computer.Start();
    }
}