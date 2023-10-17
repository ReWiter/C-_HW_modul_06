using System.Runtime.CompilerServices;

namespace N1
{
    class Money
    {
        public int Value;
        public int Value2;
        public Money(int value, int value2)
        {
            Value = value;
            Value2 = value2;
        }
        public virtual void Show()
        {
            Console.WriteLine($"{Value},{Value2}");
        }

        public virtual void summary()
        {
            Value += Value2;
        }
    }
    class Product : Money
    {
        public int Val;
        public int Val2;
        public Product(int value, int value2, int val, int val2) : base(value, value2)
        {
            Val = val;
            Val2 = val2;
        }
        public override void summary()
        {
            Val = Value - Val;
            Val2 = Value2 - Val2;
        }
        public override void Show()
        {
            Console.WriteLine($"{Val},{Val2}");
        }
    }
    class Prog
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            Money to = new Money(a, b);
            Money tor = new Product(a, b, c, d);
            to.Show();
            tor.summary();
            tor.Show();
        }
    }
}
namespace N2
{
    class Device
    {
        public string a;
        public Device(string a)
        {
            this.a = a;
        }
        public virtual void Sound() { }
        public virtual void Show()
        {
            Console.WriteLine($"Устройство-{a}");
        }
        public virtual void Des() { }
    }
    class Chai : Device
    {
        public string b;
        public string c;
        public Chai(string a) : base(a) { }
        public override void Sound()
        {
            b = Console.ReadLine();
            Console.WriteLine($"Звук-{b}");
        }
        public override void Show()
        {
            base.Show();
        }
        public override void Des()
        {
            c = Console.ReadLine();
            Console.WriteLine($"Описание-{c}");
        }
    }
    class Car : Device
    {
        public string b = "o";
        public string c = "o";
        public Car(string a) : base(a) { }
        public override void Sound()
        {
            b = Console.ReadLine();
            Console.WriteLine($"Звук-{b}");
        }
        public override void Show()
        {
            base.Show();
        }
        public override void Des()
        {
            c = Console.ReadLine();
            Console.WriteLine($"Описание-{c}");
        }
    }
    class Microwave : Device
    {
        public string b = "o";
        public string c = "o";
        public Microwave(string a) : base(a) { }
        public override void Sound()
        {
            b = Console.ReadLine();
            Console.WriteLine($"Звук-{b}");
        }
        public override void Show()
        {
            base.Show();
        }
        public override void Des()
        {
            c = Console.ReadLine();
            Console.WriteLine($"Описание-{c}");
        }
    }
    class Prog
    {
        static void Main(string[] args)
        {
            Device[] p ={
                new Chai("Чайник"),
                new Microwave("Микроволновка"),
                new Car("Автомобиль")
            };
            foreach (Device device in p)
            {
                device.Show();
                device.Sound();
                device.Des();
            }
        }
    }
}
namespace N3
{
    class MDevice
    {
        public string a;
        public MDevice(string a)
        {
            this.a = a;
        }
        public virtual void Sound() { }
        public virtual void Show()
        {
            Console.WriteLine($"Устройство-{a}");
        }
        public virtual void Des() { }
        public virtual void History() { }
    }
    class Scrip : MDevice
    {
        public string b = "o";
        public string c = "o";
        public string d = "o";
        public Scrip(string a) : base(a) { }
        public override void Sound()
        {
            b = Console.ReadLine();
            Console.WriteLine($"Звук-{b}");
        }
        public override void Show()
        {
            base.Show();
        }
        public override void Des()
        {
            c = Console.ReadLine();
            Console.WriteLine($"Описание-{c}");
        }
        public override void History()
        {
            d = Console.ReadLine();
            Console.WriteLine($"История-{c}");
        }
    }
    class Tromb : MDevice
    {
        public string b = "o";
        public string c = "o";
        public string d = "o";
        public Tromb(string a) : base(a) { }
        public override void Sound()
        {
            b = Console.ReadLine();
            Console.WriteLine($"Звук-{b}");
        }
        public override void Show()
        {
            base.Show();
        }
        public override void Des()
        {
            c = Console.ReadLine();
            Console.WriteLine($"Описание-{c}");
        }
        public override void History()
        {
            d = Console.ReadLine();
            Console.WriteLine($"История-{c}");
        }
    }
    class Ukule : MDevice
    {
        public string b = "o";
        public string c = "o";
        public string d = "o";
        public Ukule(string a) : base(a) { }
        public override void Sound()
        {
            b = Console.ReadLine();
            Console.WriteLine($"Звук-{b}");
        }
        public override void Show()
        {
            base.Show();
        }
        public override void Des()
        {
            c = Console.ReadLine();
            Console.WriteLine($"Описание-{c}");
        }
        public override void History()
        {
            d = Console.ReadLine();
            Console.WriteLine($"История-{c}");
        }
    }
    class Violo : MDevice
    {
        public string b = "o";
        public string c = "o";
        public string d = "o";
        public Violo(string a) : base(a) { }
        public override void Sound()
        {
            b = Console.ReadLine();
            Console.WriteLine($"Звук-{b}");
        }
        public override void Show()
        {
            base.Show();
        }
        public override void Des()
        {
            c = Console.ReadLine();
            Console.WriteLine($"Описание-{c}");
        }
        public override void History()
        {
            d = Console.ReadLine();
            Console.WriteLine($"История-{c}");
        }
    }
    class Prog
    {
        static void Main(string[] args)
        {
            MDevice[] p ={
                new Scrip("Скрипка"),
                new Tromb("Тромбон"),
                new Ukule("Укулеле"),
                new Violo("Виолончель")
            };
            foreach (MDevice device in p)
            {
                device.Show();
                device.Sound();
                device.Des();
                device.History();
            }
        }
    }
}
namespace N4
{
    abstract class Worker
    {
        public abstract void Print();
    }
    class President : Worker
    {
        public string a;
        public President(string a)
        {
            this.a = a;
        }
        public override void Print()
        {
            Console.WriteLine(a);
        }
    }
    class Security : Worker
    {
        public string a;
        public Security(string a)
        {
            this.a = a;
        }
        public override void Print()
        {
            Console.WriteLine(a);
        }
    }
    class Manager : Worker
    {
        public string a;
        public Manager(string a)
        {
            this.a = a;
        }
        public override void Print()
        {
            Console.WriteLine(a);
        }
    }
    class Engineer : Worker
    {
        public string a;
        public Engineer(string a)
        {
            this.a = a;
        }
        public override void Print()
        {
            Console.WriteLine(a);
        }
    }
    class Prog
    {
        static void Main(string[] args)
        {
            Worker[] worker = {
            new President("Президент"),
            new Security("Охрана"),
            new Manager("Менеджер"),
            new Engineer("Инженер")
            };
            foreach (Worker w in worker)
            {
                w.Print();
            }
        }
    }
}