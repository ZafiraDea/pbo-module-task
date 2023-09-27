using InheritanceLaptop;
using System;
using System.Reflection.Metadata;

namespace InProcessor
{
class Processor
{
    public string merk, tipe;
}
    class intel : Processor
    {
        public intel()
        {
            merk = "intel";
        }
    }

    class Corei3 : intel
    {
        public Corei3()
        {
            tipe = "Core i3";
        }
    }

    class Corei5 : intel
    {
        public Corei5()
        {
            tipe = "Core i5";
        }
    }

    class Corei7 : intel
    {
        public Corei7()
        {
            tipe = "Core i7";
        }
    }

    class Amd : Processor
    {
        public Amd()
        {
            merk = "AMD";
        }
    }

    class Ryzen : Amd
    {
        public Ryzen()
        {
            tipe = "RYZEN";
        }
    }

    class Athlon : Amd
    {
        public Athlon()
        {
            tipe = "ATHLON";
        }
    }
}


namespace VGA
{
    class Vga
    {
        public string merk;
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            merk = "Nvidia";
        }
    }

    class AMD : Vga
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
}


class Laptop
{
    public string merk, tipe;
    public VGA.Vga vga;
    public InProcessor.Processor processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine("Laptop " + merk + " " + tipe + " " + "menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine("Laptop " + merk + " " + tipe + " " + "mati");
    }
}

namespace InheritanceLaptop
{
    class ASUS : Laptop
    {
        public ASUS()
        {
            merk = "ASUS";
        }
    }
    class ROG : ASUS
    {
        public ROG()
        {
            tipe = "ROG";
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook()
        {
            tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ACER : Laptop
    {
        public ACER()
        {
            merk = "ACER";
        }
    }
    class Swift : ACER
    {
        public Swift()
        {
            tipe = "Swift";
        }
    }
    class Predator : ACER
    {
        public Predator()
        {
            tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine("Laptop " + merk + " " + tipe + " " + "sedang memainkan game");
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo()
        {
            merk = "Lenovo";
        }
    }
    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            tipe = "IdeaPad";
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            tipe = "Legion";
        }
    }
}


namespace Tugas
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();
            laptop1 = new InheritanceLaptop.Vivobook();
            laptop1.vga = new VGA.Nvidia();
            laptop1.processor = new InProcessor.Corei5();
            //laptop1.Ngoding();  //SOAL 2
            
            //SOAL 3
            Console.WriteLine($"Laptop Merk VGA : {laptop1.vga.merk}");
            Console.WriteLine($"Laptop Merk Processor : {laptop1.processor.merk}");
            Console.WriteLine($"Tipe Processor : {laptop1.processor.tipe}");

            Laptop laptop2 = new InheritanceLaptop.IdeaPad();
            laptop2.vga = new VGA.AMD();
            laptop2.processor = new InProcessor.Ryzen();
            laptop2.LaptopDinyalakan(); //SOAL 1
            laptop2.LaptopDimatikan(); //SOAL 1

            Predator predator = new InheritanceLaptop.Predator();
            predator.vga = new VGA.AMD();
            predator.processor = new InProcessor.Corei7();
            predator.BermainGame(); //SOAL 4

            ACER acer = new ACER();
            acer = new Predator();
            //acer.BermainGame(); //SOAL 5
        }
    }
}
