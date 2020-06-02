using System;
using System.Collections.Generic;

namespace ЛР3
{
    class Program
    {
        static public List<Table> TableList;
        static public List<Chair> ChairList;
        static public List<Shelf> ShelfList;
        static public List<Сupboard> СupboardList;
        static public List<Nightstand> NightstandList;
        static void Main(string[] args)
        {
            TableList = new List<Table>();
            ChairList = new List<Chair>();
            ShelfList = new List<Shelf>();
            СupboardList = new List<Сupboard>();
            NightstandList = new List<Nightstand>();
            start: Console.WriteLine("Программа учета мебели");
            Console.WriteLine("1 - посмотреть мебель");
            Console.WriteLine("2 - посмотреть мебель(подробная информация)");
            Console.WriteLine("3 - добавить мебель");
            Console.WriteLine("4 - выход");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    foreach (Table item in TableList)
                    {
                        item.AboutFurniture();
                    }
                    foreach (Chair item in ChairList)
                    {
                        item.AboutFurniture();
                    }
                    foreach (Shelf item in ShelfList)
                    {
                        item.AboutFurniture();
                    }
                    foreach (Сupboard item in СupboardList)
                    {
                        item.AboutFurniture();
                    }
                    foreach (Nightstand item in NightstandList)
                    {
                        item.AboutFurniture();
                    }
                    goto start;
                case 2:
                    foreach (Table item in TableList)
                    {
                        item.AboutFurniture(true);
                    }
                    foreach (Chair item in ChairList)
                    {
                        item.AboutFurniture(true);
                    }
                    foreach (Shelf item in ShelfList)
                    {
                        item.AboutFurniture(true);
                    }
                    foreach (Сupboard item in СupboardList)
                    {
                        item.AboutFurniture(true);
                    }
                    foreach (Nightstand item in NightstandList)
                    {
                        item.AboutFurniture(true);
                    }
                    goto start;
                case 3:
                    Console.WriteLine("Укажите тип мебели:");
                    Console.WriteLine("1 - Стол");
                    Console.WriteLine("2 - Стул");
                    Console.WriteLine("3 - Полки");
                    Console.WriteLine("4 - Шкафы");
                    Console.WriteLine("5 - Тумбочки");
                    n = Convert.ToInt32(Console.ReadLine());
                    string name;
                    string model;
                    string product_code;
                    string color;
                    double price;
                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Укажите название:");
                            name = Console.ReadLine();
                            Console.WriteLine("Укажите модель:");
                            model = Console.ReadLine();
                            Console.WriteLine("Укажите код товара:");
                            product_code = Console.ReadLine();
                            Console.WriteLine("Укажите цвет:");
                            color = Console.ReadLine();
                            Console.WriteLine("Укажите цену:");
                            price = Convert.ToDouble(Console.ReadLine());
                            Table item = new Table(name, model, product_code, color, price);
                            TableList.Add(item);
                            Console.WriteLine("Товар успешно добавлен!");
                            goto start;
                        case 2:
                            Console.WriteLine("Укажите название:");
                            name = Console.ReadLine();
                            Console.WriteLine("Укажите модель:");
                            model = Console.ReadLine();
                            Console.WriteLine("Укажите код товара:");
                            product_code = Console.ReadLine();
                            Console.WriteLine("Укажите цвет:");
                            color = Console.ReadLine();
                            Console.WriteLine("Укажите цену:");
                            price = Convert.ToDouble(Console.ReadLine());
                            Chair item2 = new Chair(name, model, product_code, color, price);
                            ChairList.Add(item2);
                            Console.WriteLine("Товар успешно добавлен!");
                            goto start;
                        case 3:
                            Console.WriteLine("Укажите название:");
                            name = Console.ReadLine();
                            Console.WriteLine("Укажите модель:");
                            model = Console.ReadLine();
                            Console.WriteLine("Укажите код товара:");
                            product_code = Console.ReadLine();
                            Console.WriteLine("Укажите цвет:");
                            color = Console.ReadLine();
                            Console.WriteLine("Укажите цену:");
                            price = Convert.ToDouble(Console.ReadLine());
                            Shelf item3 = new Shelf(name, model, product_code, color, price);
                            ShelfList.Add(item3);
                            Console.WriteLine("Товар успешно добавлен!");
                            goto start;
                        case 4:
                            Console.WriteLine("Укажите название:");
                            name = Console.ReadLine();
                            Console.WriteLine("Укажите модель:");
                            model = Console.ReadLine();
                            Console.WriteLine("Укажите код товара:");
                            product_code = Console.ReadLine();
                            Console.WriteLine("Укажите цвет:");
                            color = Console.ReadLine();
                            Console.WriteLine("Укажите цену:");
                            price = Convert.ToDouble(Console.ReadLine());
                            Сupboard item4 = new Сupboard(name, model, product_code, color, price);
                            СupboardList.Add(item4);
                            Console.WriteLine("Товар успешно добавлен!");
                            goto start;
                        case 5:
                            Console.WriteLine("Укажите название:");
                            name = Console.ReadLine();
                            Console.WriteLine("Укажите модель:");
                            model = Console.ReadLine();
                            Console.WriteLine("Укажите код товара:");
                            product_code = Console.ReadLine();
                            Console.WriteLine("Укажите цвет:");
                            color = Console.ReadLine();
                            Console.WriteLine("Укажите цену:");
                            price = Convert.ToDouble(Console.ReadLine());
                            Nightstand item5 = new Nightstand(name, model, product_code, color, price);
                            NightstandList.Add(item5);
                            Console.WriteLine("Товар успешно добавлен!");
                            goto start;
                        default:
                            Console.WriteLine("Вы не указали тип мебели!");
                            goto start;
                    }
                case 4:
                    break;
                default:
                    goto start;
            }
        }
    }
    public class Furniture//Класс мебели
    {
        private string type;
        private string name;
        private string model;
        private string product_code;
        private string color;
        private double price;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string ProductCode
        {
            get
            {
                return product_code;
            }
            set
            {
                product_code = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public virtual void AboutFurniture()
        {

        }
        public virtual void AboutFurniture(bool check)
        {

        }
    }
    public class Table : Furniture//Класс столов
    {
        static int count = 0;

        public Table(string name, string model, string product_code, string color, double price)
        {
            Type = "Стол";
            Name = name;
            Model = model;
            ProductCode = product_code;
            Color = color;
            Price = price;
            count++;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public override void AboutFurniture()
        {
            Console.WriteLine("");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("");
        }
        public override void AboutFurniture(bool check)
        {
            Console.WriteLine("");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Код товара: " + ProductCode);
            Console.WriteLine("Цвет: " + Color);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Кол-во на складе: " + Count);
            Console.WriteLine("");
        }
    }
    public class Chair : Furniture//Класс стульев
    {
        static int count = 0;

        public Chair(string name, string model, string product_code, string color, double price)
        {
            Type = "Стул";
            Name = name;
            Model = model;
            ProductCode = product_code;
            Color = color;
            Price = price;
            count++;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public override void AboutFurniture()
        {
            Console.WriteLine("");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("");
        }
        public override void AboutFurniture(bool check)
        {
            Console.WriteLine("");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Код товара: " + ProductCode);
            Console.WriteLine("Цвет: " + Color);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Кол-во на складе: " + Count);
            Console.WriteLine("");
        }
    }
    public class Shelf : Furniture//Класс полок
    {
        static int count = 0;

        public Shelf(string name, string model, string product_code, string color, double price)
        {
            Type = "Полка";
            Name = name;
            Model = model;
            ProductCode = product_code;
            Color = color;
            Price = price;
            count++;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public override void AboutFurniture()
        {
            Console.WriteLine("");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("");
        }
        public override void AboutFurniture(bool check)
        {
            Console.WriteLine("");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Код товара: " + ProductCode);
            Console.WriteLine("Цвет: " + Color);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Кол-во на складе: " + Count);
            Console.WriteLine("");
        }
    }
    public class Сupboard : Furniture//Класс шкафов
    {
        static int count = 0;

        public Сupboard(string name, string model, string product_code, string color, double price)
        {
            Type = "Шкаф";
            Name = name;
            Model = model;
            ProductCode = product_code;
            Color = color;
            Price = price;
            count++;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public override void AboutFurniture()
        {
            Console.WriteLine("");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("");
        }
        public override void AboutFurniture(bool check)
        {
            Console.WriteLine("");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Код товара: " + ProductCode);
            Console.WriteLine("Цвет: " + Color);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Кол-во на складе: " + Count);
            Console.WriteLine("");
        }
    }
    public class Nightstand : Furniture//Класс тумбочек
    {
        static int count = 0;

        public Nightstand(string name, string model, string product_code, string color, double price)
        {
            Type = "Тумба";
            Name = name;
            Model = model;
            ProductCode = product_code;
            Color = color;
            Price = price;
            count++;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public override void AboutFurniture()
        {
            Console.WriteLine("");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("");
        }
        public override void AboutFurniture(bool check)
        {
            Console.WriteLine("");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Код товара: " + ProductCode);
            Console.WriteLine("Цвет: " + Color);
            Console.WriteLine("Цена: " + Price);
            Console.WriteLine("Кол-во на складе: " + Count);
            Console.WriteLine("");
        }
    }
}
