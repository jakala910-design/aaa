using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_All_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== ЗАДАНИЕ 1: Животное ===");
            Task1.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 2: Транспорт ===");
            Task2.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 3: Человек и студент ===");
            Task3.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 4: Сотрудники ===");
            Task4.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 5: Фигуры ===");
            Task5.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 6: Транспорт с методом движения ===");
            Task6.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 7: Работник магазина ===");
            Task7.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 8: Компьютеры ===");
            Task8.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 9: Книги ===");
            Task9.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 10: Домашние животные ===");
            Task10.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 11: Банковские счета ===");
            Task11.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 12: Транспортная компания ===");
            Task12.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 13: Работники компании ===");
            Task13.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 14: Система образования ===");
            Task14.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 15: Военная техника ===");
            Task15.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 16: Игровые персонажи ===");
            Task16.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 17: Электронные устройства ===");
            Task17.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 18: Платежи ===");
            Task18.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 19: Сотрудники с бонусами ===");
            Task19.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 20: Животные зоопарка ===");
            Task20.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 21: Абстрактные фигуры ===");
            Task21.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 22: Интернет-магазин ===");
            Task22.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 23: Система транспорта ===");
            Task23.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 24: Больница ===");
            Task24.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 25: Система сотрудников с уровнями наследования ===");
            Task25.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 26: Игра: персонажи ===");
            Task26.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 27: Файлы ===");
            Task27.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 28: Система оплаты зарплаты ===");
            Task28.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 29: Полиморфизм + наследование ===");
            Task29.Run();

            Console.WriteLine("\n=== ЗАДАНИЕ 30: Итоговое задание — система автопарка ===");
            Task30.Run();
        }
    }

    // ==========================================
    // 1. Животное
    // ==========================================
    namespace Task1
    {
        class Animal
        {
            public virtual void Speak() => Console.WriteLine("Животное издает звук.");
        }
        class Dog : Animal
        {
            public override void Speak() => Console.WriteLine("Гав-гав!");
        }
        class Cat : Animal
        {
            public override void Speak() => Console.WriteLine("Мяу!");
        }
        public static void Run()
        {
            Animal a = new Animal(); a.Speak();
            Animal d = new Dog(); d.Speak();
            Animal c = new Cat(); c.Speak();
        }
    }

    // ==========================================
    // 2. Транспорт
    // ==========================================
    namespace Task2
    {
        class Vehicle
        {
            public string Brand { get; set; }
            public double Speed { get; set; }
        }
        class Car : Vehicle
        {
            public int DoorsCount { get; set; }
        }
        class Motorcycle : Vehicle
        {
            public bool HasBox { get; set; }
        }
        public static void Run()
        {
            Car car = new Car { Brand = "Toyota", Speed = 180, DoorsCount = 4 };
            Motorcycle moto = new Motorcycle { Brand = "Yamaha", Speed = 220, HasBox = false };
            Console.WriteLine($"Авто: {car.Brand}, Скорость: {car.Speed}, Дверей: {car.DoorsCount}");
            Console.WriteLine($"Мото: {moto.Brand}, Скорость: {moto.Speed}, Кофр: {moto.HasBox}");
        }
    }

    // ==========================================
    // 3. Человек и студент
    // ==========================================
    namespace Task3
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        class Student : Person
        {
            public string Specialty { get; set; }
            public int Course { get; set; }
            public void PrintInfo() => Console.WriteLine($"Студент: {Name}, Возраст: {Age}, Специальность: {Specialty}, Курс: {Course}");
        }
        public static void Run()
        {
            Student st = new Student { Name = "Алексей", Age = 20, Specialty = "ПИ", Course = 2 };
            st.PrintInfo();
        }
    }

    // ==========================================
    // 4. Сотрудники
    // ==========================================
    namespace Task4
    {
        class Employee
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }
        }
        class Manager : Employee
        {
            public int TeamSize { get; set; }
        }
        class Developer : Employee
        {
            public string ProgrammingLanguage { get; set; }
        }
        public static void Run()
        {
            Manager m = new Manager { Name = "Ольга", Salary = 120000, TeamSize = 5 };
            Developer d = new Developer { Name = "Иван", Salary = 150000, ProgrammingLanguage = "C#" };
            Console.WriteLine($"Менеджер: {m.Name}, ЗП: {m.Salary}, Команда: {m.TeamSize}");
            Console.WriteLine($"Разработчик: {d.Name}, ЗП: {d.Salary}, Язык: {d.ProgrammingLanguage}");
        }
    }

    // ==========================================
    // 5. Фигуры
    // ==========================================
    namespace Task5
    {
        class Shape
        {
            public virtual double GetArea() => 0;
        }
        class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public override double GetArea() => Width * Height;
        }
        class Circle : Shape
        {
            public double Radius { get; set; }
            public override double GetArea() => Math.PI * Radius * Radius;
        }
        public static void Run()
        {
            Shape rect = new Rectangle { Width = 5, Height = 4 };
            Shape circ = new Circle { Radius = 3 };
            Console.WriteLine($"Площадь прямоугольника: {rect.GetArea()}");
            Console.WriteLine($"Площадь круга: {circ.GetArea():F2}");
        }
    }

    // ==========================================
    // 6. Транспорт с методом движения
    // ==========================================
    namespace Task6
    {
        class Vehicle
        {
            public virtual void Move() => Console.WriteLine("Транспорт движется.");
        }
        class Car : Vehicle
        {
            public override void Move() => Console.WriteLine("Машина едет по дороге.");
        }
        class Bus : Vehicle
        {
            public override void Move() => Console.WriteLine("Автобус везет пассажиров по маршруту.");
        }
        class Train : Vehicle
        {
            public override void Move() => Console.WriteLine("Поезд едет по рельсам.");
        }
        public static void Run()
        {
            Vehicle[] vehicles = { new Car(), new Bus(), new Train() };
            foreach (var v in vehicles) v.Move();
        }
    }

    // ==========================================
    // 7. Работник магазина
    // ==========================================
    namespace Task7
    {
        class Worker
        {
            public string Name { get; set; }
            public string Position { get; set; }
        }
        class Cashier : Worker { }
        class Seller : Worker { }
        public static void Run()
        {
            Cashier c = new Cashier { Name = "Анна", Position = "Кассир" };
            Seller s = new Seller { Name = "Сергей", Position = "Продавец-консультант" };
            Console.WriteLine($"{c.Position} {c.Name} работает на кассе.");
            Console.WriteLine($"{s.Position} {s.Name} помогает клиентам в зале.");
        }
    }

    // ==========================================
    // 8. Компьютеры
    // ==========================================
    namespace Task8
    {
        class Computer
        {
            public string Processor { get; set; }
            public int RAM { get; set; }
        }
        class Laptop : Computer
        {
            public double BatteryLifeHours { get; set; }
        }
        class Desktop : Computer
        {
            public bool HasDedicatedGPU { get; set; }
        }
        public static void Run()
        {
            Laptop laptop = new Laptop { Processor = "Intel i7", RAM = 16, BatteryLifeHours = 8.5 };
            Desktop desktop = new Desktop { Processor = "AMD Ryzen 9", RAM = 32, HasDedicatedGPU = true };
            Console.WriteLine($"Ноутбук: {laptop.Processor}, ОЗУ: {laptop.RAM}ГБ, Аккумулятор: {laptop.BatteryLifeHours}ч");
            Console.WriteLine($"ПК: {desktop.Processor}, ОЗУ: {desktop.RAM}ГБ, Дискретная видеокарта: {desktop.HasDedicatedGPU}");
        }
    }

    // ==========================================
    // 9. Книги
    // ==========================================
    namespace Task9
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
        }
        class PaperBook : Book
        {
            public int PagesCount { get; set; }
        }
        class EBook : Book
        {
            public double FileSizeMB { get; set; }
        }
        public static void Run()
        {
            PaperBook pb = new PaperBook { Title = "Мастер и Маргарита", Author = "М. Булгаков", PagesCount = 480 };
            EBook eb = new EBook { Title = "Чистый код", Author = "Р. Мартин", FileSizeMB = 5.2 };
            Console.WriteLine($"Бумажная книга: «{pb.Title}», {pb.Author}, страниц: {pb.PagesCount}");
            Console.WriteLine($"Электронная книга: «{eb.Title}», {eb.Author}, размер: {eb.FileSizeMB} МБ");
        }
    }

    // ==========================================
    // 10. Домашние животные
    // ==========================================
    namespace Task10
    {
        class Pet
        {
            public virtual void Eat() => Console.WriteLine("Питомец ест.");
        }
        class Dog : Pet { public override void Eat() => Console.WriteLine("Собака грызет кость."); }
        class Cat : Pet { public override void Eat() => Console.WriteLine("Кошка ест корм."); }
        class Parrot : Pet { public override void Eat() => Console.WriteLine("Попугай клюет зерна."); }
        public static void Run()
        {
            Pet[] pets = { new Dog(), new Cat(), new Parrot() };
            foreach (var p in pets) p.Eat();
        }
    }

    // ==========================================
    // 11. Банковские счета
    // ==========================================
    namespace Task11
    {
        class BankAccount
        {
            public decimal Balance { get; protected set; }
            public virtual void Deposit(decimal amount) => Balance += amount;
            public virtual void Withdraw(decimal amount)
            {
                if (Balance >= amount) Balance -= amount;
            }
        }
        class SavingsAccount : BankAccount
        {
            public decimal InterestRate { get; set; } = 0.05m;
            public void AddInterest() => Balance += Balance * InterestRate;
        }
        class CreditAccount : BankAccount
        {
            public decimal CreditLimit { get; set; } = 10000m;
            public override void Withdraw(decimal amount)
            {
                if (Balance + CreditLimit >= amount) Balance -= amount;
            }
        }
        public static void Run()
        {
            SavingsAccount sa = new SavingsAccount();
            sa.Deposit(1000);
            sa.AddInterest();
            Console.WriteLine($"Баланс сберегательного счета с процентами: {sa.Balance}");

            CreditAccount ca = new CreditAccount();
            ca.Withdraw(5000);
            Console.WriteLine($"Баланс кредитного счета после снятия: {ca.Balance}");
        }
    }

    // ==========================================
    // 12. Транспортная компания
    // ==========================================
    namespace Task12
    {
        abstract class Transport
        {
            public abstract decimal CalculateCost(double distance);
        }
        class Car : Transport
        {
            public override decimal CalculateCost(double distance) => (decimal)distance * 10m;
        }
        class Truck : Transport
        {
            public override decimal CalculateCost(double distance) => (decimal)distance * 25m;
        }
        class Bus : Transport
        {
            public override decimal CalculateCost(double distance) => (decimal)distance * 15m;
        }
        public static void Run()
        {
            Transport[] fleet = { new Car(), new Truck(), new Bus() };
            foreach (var t in fleet)
                Console.WriteLine($"Стоимость поездки на 100 км: {t.CalculateCost(100)} руб.");
        }
    }

    // ==========================================
    // 13. Работники компании
    // ==========================================
    namespace Task13
    {
        class Employee
        {
            public virtual decimal GetSalary() => 50000m;
        }
        class Programmer : Employee
        {
            public override decimal GetSalary() => 150000m;
        }
        class Designer : Employee
        {
            public override decimal GetSalary() => 110000m;
        }
        class Manager : Employee
        {
            public override decimal GetSalary() => 130000m;
        }
        public static void Run()
        {
            Employee[] emps = { new Programmer(), new Designer(), new Manager() };
            foreach (var e in emps)
                Console.WriteLine($"Зарплата сотрудника: {e.GetSalary()}");
        }
    }

    // ==========================================
    // 14. Система образования
    // ==========================================
    namespace Task14
    {
        class Person
        {
            public string Name { get; set; }
        }
        class Student : Person
        {
            public string University { get; set; }
        }
        class GraduateStudent : Student
        {
            public string ThesisTopic { get; set; }
            public void PrintFullInfo() => Console.WriteLine($"Аспирант: {Name}, ВУЗ: {University}, Тема диссертации: {ThesisTopic}");
        }
        public static void Run()
        {
            GraduateStudent gs = new GraduateStudent { Name = "Дмитрий", University = "МГУ", ThesisTopic = "Искусственный интеллект" };
            gs.PrintFullInfo();
        }
    }

    // ==========================================
    // 15. Военная техника
    // ==========================================
    namespace Task15
    {
        class MilitaryVehicle
        {
            public virtual void Attack() => Console.WriteLine("Техника атакует.");
        }
        class Tank : MilitaryVehicle
        {
            public override void Attack() => Console.WriteLine("Танк стреляет из пушки!");
        }
        class Helicopter : MilitaryVehicle
        {
            public override void Attack() => Console.WriteLine("Вертолет выпускает ракеты!");
        }
        class ArmoredCar : MilitaryVehicle
        {
            public override void Attack() => Console.WriteLine("Броневичок ведет пулеметный огонь!");
        }
        public static void Run()
        {
            MilitaryVehicle[] units = { new Tank(), new Helicopter(), new ArmoredCar() };
            foreach (var u in units) u.Attack();
        }
    }

    // ==========================================
    // 16. Игровые персонажи
    // ==========================================
    namespace Task16
    {
        class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int Damage { get; set; }
            public virtual void Attack() => Console.WriteLine($"{Name} атаковал.");
        }
        class Warrior : Character
        {
            public override void Attack() => Console.WriteLine($"{Name} (Воин) наносит мощный удар мечом на {Damage} урона.");
        }
        class Mage : Character
        {
            public override void Attack() => Console.WriteLine($"{Name} (Маг) кастует огненный шар на {Damage} урона.");
        }
        class Archer : Character
        {
            public override void Attack() => Console.WriteLine($"{Name} (Лучник) пускает стрелу на {Damage} урона.");
        }
        public static void Run()
        {
            Character w = new Warrior { Name = "Артур", Damage = 50 };
            Character m = new Mage { Name = "Гендальф", Damage = 60 };
            Character a = new Archer { Name = "Леголас", Damage = 45 };
            w.Attack(); m.Attack(); a.Attack();
        }
    }

    // ==========================================
    // 17. Электронные устройства
    // ==========================================
    namespace Task17
    {
        class Device
        {
            public virtual void TurnOn() => Console.WriteLine("Устройство включено.");
            public virtual void TurnOff() => Console.WriteLine("Устройство выключено.");
        }
        class Phone : Device
        {
            public override void TurnOn() => Console.WriteLine("Телефон завибрировал и показал заставку.");
        }
        class Computer : Device
        {
            public override void TurnOn() => Console.WriteLine("ПК загружает операционную систему.");
        }
        class Television : Device
        {
            public override void TurnOn() => Console.WriteLine("Телевизор включил экран и перешел на канал 1.");
        }
        public static void Run()
        {
            Device[] devices = { new Phone(), new Computer(), new Television() };
            foreach (var d in devices) { d.TurnOn(); d.TurnOff(); }
        }
    }

    // ==========================================
    // 18. Платежи
    // ==========================================
    namespace Task18
    {
        abstract class Payment
        {
            public abstract void Pay(double amount);
        }
        class CashPayment : Payment
        {
            public override void Pay(double amount) => Console.WriteLine($"Оплата наличными на сумму {amount} руб.");
        }
        class CardPayment : Payment
        {
            public override void Pay(double amount) => Console.WriteLine($"Оплата банковской картой на сумму {amount} руб.");
        }
        class OnlinePayment : Payment
        {
            public override void Pay(double amount) => Console.WriteLine($"Онлайн-оплата через интернет на сумму {amount} руб.");
        }
        public static void Run()
        {
            Payment[] payments = { new CashPayment(), new CardPayment(), new OnlinePayment() };
            foreach (var p in payments) p.Pay(1500.0);
        }
    }

    // ==========================================
    // 19. Сотрудники с бонусами
    // ==========================================
    namespace Task19
    {
        class Employee
        {
            public decimal BaseSalary { get; set; }
            public virtual decimal GetTotalSalary() => BaseSalary;
        }
        class Manager : Employee
        {
            public override decimal GetTotalSalary() => BaseSalary * 1.2m; // 20% бонус
        }
        class Developer : Employee
        {
            public override decimal GetTotalSalary() => BaseSalary * 1.15m; // 15% бонус
        }
        class SalesManager : Employee
        {
            public override decimal GetTotalSalary() => BaseSalary * 1.3m; // 30% бонус
        }
        public static void Run()
        {
            Employee[] staff = {
                new Manager { BaseSalary = 100000 },
                new Developer { BaseSalary = 120000 },
                new SalesManager { BaseSalary = 80000 }
            };
            foreach (var s in staff)
                Console.WriteLine($"Зарплата с бонусом: {s.GetTotalSalary()}");
        }
    }

    // ==========================================
    // 20. Животные зоопарка
    // ==========================================
    namespace Task20
    {
        class Animal
        {
            public virtual void Eat() => Console.WriteLine("Животное ест еду.");
            public virtual void MakeSound() => Console.WriteLine("Животное издает звук.");
        }
        class Lion : Animal { public override void Eat() => Console.WriteLine("Лев ест мясо."); public override void MakeSound() => Console.WriteLine("Ррррыг!"); }
        class Elephant : Animal { public override void Eat() => Console.WriteLine("Слон ест ветки и траву."); public override void MakeSound() => Console.WriteLine("Уууу-у!"); }
        class Monkey : Animal { public override void Eat() => Console.WriteLine("Обезьяна ест бананы."); public override void MakeSound() => Console.WriteLine("Уу-у-а-а!"); }
        class Penguin : Animal { public override void Eat() => Console.WriteLine("Пингвин ест рыбу."); public override void MakeSound() => Console.WriteLine("Кря-писк!"); }
        class Snake : Animal { public override void Eat() => Console.WriteLine("Змея заглатывает добычу целиком."); public override void MakeSound() => Console.WriteLine("Шшшшш!"); }
        public static void Run()
        {
            Animal[] zoo = { new Lion(), new Elephant(), new Monkey(), new Penguin(), new Snake() };
            foreach (var a in zoo) { a.Eat(); a.MakeSound(); }
        }
    }

    // ==========================================
    // 21. Абстрактные фигуры
    // ==========================================
    namespace Task21
    {
        abstract class Shape
        {
            public abstract double GetArea();
        }
        class Circle : Shape
        {
            public double R { get; set; }
            public override double GetArea() => Math.PI * R * R;
        }
        class Rectangle : Shape
        {
            public double W { get; set; }
            public double H { get; set; }
            public override double GetArea() => W * H;
        }
        class Triangle : Shape
        {
            public double Base { get; set; }
            public double Height { get; set; }
            public override double GetArea() => 0.5 * Base * Height;
        }
        class Square : Shape
        {
            public double Side { get; set; }
            public override double GetArea() => Side * Side;
        }
        public static void Run()
        {
            Shape[] shapes = { new Circle { R = 5 }, new Rectangle { W = 4, H = 5 }, new Triangle { Base = 6, Height = 4 }, new Square { Side = 3 } };
            foreach (var s in shapes) Console.WriteLine($"Площадь: {s.GetArea():F2}");
        }
    }

    // ==========================================
    // 22. Интернет-магазин
    // ==========================================
    namespace Task22
    {
        abstract class Product
        {
            public string Name { get; set; }
            public decimal BasePrice { get; set; }
            public abstract decimal GetFinalPrice();
        }
        class Electronics : Product
        {
            public override decimal GetFinalPrice() => BasePrice * 1.1m; // налог 10%
        }
        class Clothing : Product
        {
            public override decimal GetFinalPrice() => BasePrice * 0.9m; // скидка 10%
        }
        class Food : Product
        {
            public override decimal GetFinalPrice() => BasePrice; // без изменений
        }
        public static void Run()
        {
            Product[] cart = {
                new Electronics { Name = "Телефон", BasePrice = 50000 },
                new Clothing { Name = "Куртка", BasePrice = 10000 },
                new Food { Name = "Молоко", BasePrice = 80 }
            };
            foreach (var p in cart)
                Console.WriteLine($"Товар: {p.Name}, Итоговая цена: {p.GetFinalPrice()}");
        }
    }

    // ==========================================
    // 23. Система транспорта
    // ==========================================
    namespace Task23
    {
        abstract class Transport
        {
            public abstract void Move();
            public abstract double GetFuelConsumption(); // литров на 100 км
        }
        class Car : Transport
        {
            public override void Move() => Console.WriteLine("Машина едет.");
            public override double GetFuelConsumption() => 8.5;
        }
        class Truck : Transport
        {
            public override void Move() => Console.WriteLine("Грузовик везет груз.");
            public override double GetFuelConsumption() => 28.0;
        }
        class Bus : Transport
        {
            public override void Move() => Console.WriteLine("Автобус перевозит пассажиров.");
            public override double GetFuelConsumption() => 22.0;
        }
        class Motorcycle : Transport
        {
            public override void Move() => Console.WriteLine("Мотоцикл быстро маневрирует.");
            public override double GetFuelConsumption() => 4.2;
        }
        public static void Run()
        {
            Transport[] list = { new Car(), new Truck(), new Bus(), new Motorcycle() };
            foreach (var t in list) { t.Move(); Console.WriteLine($"Расход: {t.GetFuelConsumption()} л/100км"); }
        }
    }

    // ==========================================
    // 24. Больница
    // ==========================================
    namespace Task24
    {
        abstract class MedicalWorker
        {
            public abstract void Work();
        }
        class Doctor : MedicalWorker
        {
            public override void Work() => Console.WriteLine("Врач ведет прием пациентов и ставит диагнозы.");
        }
        class Nurse : MedicalWorker
        {
            public override void Work() => Console.WriteLine("Медсестра ставит уколы и выдает лекарства.");
        }
        class Surgeon : MedicalWorker
        {
            public override void Work() => Console.WriteLine("Хирург проводит сложную операцию в операционной.");
        }
        public static void Run()
        {
            MedicalWorker[] staff = { new Doctor(), new Nurse(), new Surgeon() };
            foreach (var s in staff) s.Work();
        }
    }

    // ==========================================
    // 25. Система сотрудников с уровнями наследования
    // ==========================================
    namespace Task25
    {
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public void Breathe() => Console.WriteLine("Человек дышит.");
        }
        class Employee : Person
        {
            public int EmployeeId { get; set; }
            public decimal Salary { get; set; }
            public void Work() => Console.WriteLine("Сотрудник работает.");
        }
        class Manager : Employee
        {
            public string Department { get; set; }
            public int SubordinatesCount { get; set; }
            public void ConductMeeting() => Console.WriteLine("Менеджер проводит совещание.");
        }
        class Director : Manager
        {
            public string CompanyCar { get; set; }
            public decimal SharesPercent { get; set; }
            public void SignContract() => Console.WriteLine("Директор подписал важный контракт.");
        }
        public static void Run()
        {
            Director d = new Director
            {
                FirstName = "Пётр", LastName = "Петров",
                EmployeeId = 1, Salary = 300000,
                Department = "ИТ", SubordinatesCount = 20,
                CompanyCar = "BMW", SharesPercent = 15.0m
            };
            Console.WriteLine($"Директор: {d.FirstName} {d.LastName}, Отдел: {d.Department}, ЗП: {d.Salary}");
            d.Breathe(); d.Work(); d.ConductMeeting(); d.SignContract();
        }
    }

    // ==========================================
    // 26. Игра: персонажи
    // ==========================================
    namespace Task26
    {
        abstract class Character
        {
            public abstract void Attack();
            public abstract void Defend();
            public abstract void SpecialAttack();
        }
        class Warrior : Character
        {
            public override void Attack() => Console.WriteLine("Воин бьет мечом.");
            public override void Defend() => Console.WriteLine("Воин поднимает щит.");
            public override void SpecialAttack() => Console.WriteLine("Воин совершает яростное круговое рассечение!");
        }
        class Mage : Character
        {
            public override void Attack() => Console.WriteLine("Маг стреляет магической стрелой.");
            public override void Defend() => Console.WriteLine("Маг ставит магический щит.");
            public override void SpecialAttack() => Console.WriteLine("Маг призывает метеоритный дождь!");
        }
        class Archer : Character
        {
            public override void Attack() => Console.WriteLine("Лучник стреляет из лука.");
            public override void Defend() => Console.WriteLine("Лучник отпрыгивает назад.");
            public override void SpecialAttack() => Console.WriteLine("Лучник выпускает град из 10 стрел!");
        }
        public static void Run()
        {
            Character[] chars = { new Warrior(), new Mage(), new Archer() };
            foreach (var c in chars) { c.Attack(); c.Defend(); c.SpecialAttack(); }
        }
    }

    // ==========================================
    // 27. Файлы
    // ==========================================
    namespace Task27
    {
        class File
        {
            public string Name { get; set; }
            public long SizeBytes { get; set; }
            public virtual void Open() => Console.WriteLine($"Открытие файла {Name}...");
        }
        class TextFile : File
        {
            public override void Open() => Console.WriteLine($"Открытие текстового файла {Name} в Блокноте.");
        }
        class ImageFile : File
        {
            public override void Open() => Console.WriteLine($"Открытие изображения {Name} в Просмотрщике картинок.");
        }
        class VideoFile : File
        {
            public override void Open() => Console.WriteLine($"Воспроизведение видеофайла {Name} в медиаплеере.");
        }
        public static void Run()
        {
            File[] files = {
                new TextFile { Name = "notes.txt", SizeBytes = 1024 },
                new ImageFile { Name = "photo.jpg", SizeBytes = 2048576 },
                new VideoFile { Name = "movie.mp4", SizeBytes = 1500000000 }
            };
            foreach (var f in files) f.Open();
        }
    }

    // ==========================================
    // 28. Система оплаты зарплаты
    // ==========================================
    namespace Task28
    {
        abstract class Employee
        {
            public string Name { get; set; }
            public abstract decimal CalculateSalary();
        }
        class HourlyEmployee : Employee
        {
            public decimal HourlyRate { get; set; }
            public int HoursWorked { get; set; }
            public override decimal CalculateSalary() => HourlyRate * HoursWorked;
        }
        class SalariedEmployee : Employee
        {
            public decimal MonthlySalary { get; set; }
            public override decimal CalculateSalary() => MonthlySalary;
        }
        class CommissionEmployee : Employee
        {
            public decimal BaseSalary { get; set; }
            public decimal SalesBonus { get; set; }
            public override decimal CalculateSalary() => BaseSalary + SalesBonus;
        }
        public static void Run()
        {
            List<Employee> employees = new List<Employee>
            {
                new HourlyEmployee { Name = "Олег", HourlyRate = 500, HoursWorked = 160 },
                new SalariedEmployee { Name = "Елена", MonthlySalary = 90000 },
                new CommissionEmployee { Name = "Максим", BaseSalary = 40000, SalesBonus = 35000 }
            };

            decimal totalFund = 0;
            foreach (var emp in employees)
            {
                decimal sal = emp.CalculateSalary();
                totalFund += sal;
                Console.WriteLine($"Сотрудник: {emp.Name}, Зарплата: {sal}");
            }
            Console.WriteLine($"Общий фонд зарплаты: {totalFund}");
        }
    }

    // ==========================================
    // 29. Полиморфизм + наследование
    // ==========================================
    namespace Task29
    {
        class Animal
        {
            public virtual void MakeSound() => Console.WriteLine("...");
        }
        class Dog : Animal { public override void MakeSound() => Console.WriteLine("Гав!"); }
        class Cat : Animal { public override void MakeSound() => Console.WriteLine("Мяу!"); }
        class Cow : Animal { public override void MakeSound() => Console.WriteLine("Мууу!"); }
        class Duck : Animal { public override void MakeSound() => Console.WriteLine("Кря!"); }
        class Sheep : Animal { public override void MakeSound() => Console.WriteLine("Беее!"); }

        public static void Run()
        {
            List<Animal> animals = new List<Animal> { new Dog(), new Cat(), new Cow(), new Duck(), new Sheep() };
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }
    }

    // ==========================================
    // 30. Итоговое задание — система автопарка
    // ==========================================
    namespace Task30
    {
        abstract class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public double Speed { get; set; }
            public decimal Price { get; set; }

            public abstract void Move();
            public abstract double GetFuelConsumption(); // литров на 100 км (или кВт*ч для электр)
        }

        class Car : Vehicle
        {
            public override void Move() => Console.WriteLine($"Легковой автомобиль {Brand} {Model} едет по трассе.");
            public override double GetFuelConsumption() => 7.5;
        }

        class Truck : Vehicle
        {
            public double LoadCapacityTonnes { get; set; }
            public override void Move() => Console.WriteLine($"Грузовик {Brand} {Model} перевозит тяжелый груз.");
            public override double GetFuelConsumption() => 25.0;
        }

        class Bus : Vehicle
        {
            public int PassengerCapacity { get; set; }
            public override void Move() => Console.WriteLine($"Автобус {Brand} {Model} везет пассажиров.");
            public override double GetFuelConsumption() => 18.0;
        }

        class ElectricCar : Vehicle
        {
            public int BatteryCapacityKWh { get; set; }
            public override void Move() => Console.WriteLine($"Электрокар {Brand} {Model} бесшумно едет на электротяге.");
            public override double GetFuelConsumption() => 0; // условно 0 топлива
        }

        class Motorcycle : Vehicle
        {
            public override void Move() => Console.WriteLine($"Мотоцикл {Brand} {Model} быстро ускоряется.");
            public override double GetFuelConsumption() => 4.0;
        }

        public static void Run()
        {
            List<Vehicle> fleet = new List<Vehicle>
            {
                new Car { Brand = "Toyota", Model = "Camry", Speed = 210, Price = 3000000 },
                new Truck { Brand = "Volvo", Model = "FH16", Speed = 140, Price = 8500000, LoadCapacityTonnes = 20 },
                new Bus { Brand = "Mercedes", Model = "Sprinter", Speed = 130, Price = 4500000, PassengerCapacity = 20 },
                new ElectricCar { Brand = "Tesla", Model = "Model S", Speed = 250, Price = 7000000, BatteryCapacityKWh = 100 },
                new Motorcycle { Brand = "Kawasaki", Model = "Ninja", Speed = 290, Price = 1500000 }
            };

            // Вывод информации
            Console.WriteLine("--- Список автопарка ---");
            foreach (var v in fleet)
            {
                Console.WriteLine($"{v.Brand} {v.Model} | Скорость: {v.Speed} км/ч | Цена: {v.Price} руб.");
                v.Move();
                Console.WriteLine($"Расход топлива/энергии: {v.GetFuelConsumption()}\n");
            }

            // Поиск самого быстрого и самого дорогого
            var fastest = fleet.OrderByDescending(v => v.Speed).First();
            var mostExpensive = fleet.OrderByDescending(v => v.Price).First();

            Console.WriteLine($"Самый быстрый транспорт: {fastest.Brand} {fastest.Model} ({fastest.Speed} км/ч)");
            Console.WriteLine($"Самый дорогой транспорт: {mostExpensive.Brand} {mostExpensive.Model} ({mostExpensive.Price} руб.)");
        }
    }
}