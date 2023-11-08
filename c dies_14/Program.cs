using System;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace c_dies_14
{
    internal class Program
    {
        public class Product
        {
            public long ProductID { get; set; }
            public string ProductName { get; set; }
            public int ProductPrice { get; set; }

        }
        public class Customer
        {
            public long CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string CustomerAdress { get; set; }

        }

        public class Order
        {
            public long OrderID { get; set; }
            public DateTime OrderDateTime { get; set; }
            public string Customer { get; set; }
            public List<Product> ListOfProducts { get; set; }
            //public delegate void ZakObr();
            //public event ZakObr ZOOB  ;

            public event Action<Order> OrderProcessed;


            public void OProcessed()
            {
                OrderProcessed?.Invoke(this);
                Console.WriteLine("Заказ обработан\n");
            }
        }
        public class Store
        {
            public List<Order> ZAKAZ = new List<Order>();
            public void AddOrder(Order ORDA)
            {
                ZAKAZ.Add(ORDA);
            }
            public void ProcessOrders()
            {
                foreach (var ii in ZAKAZ)
                {
                    ii.OProcessed();
                }
            }
        }
        public class Voiture
        {
            public string Mark { get; set; }
            public string Model { get; set; }
            public int Ans { get; set; }
            public string Color { get; set; }
            public int Prix { get; set; }
            public void Mostrare()
            {
                Console.WriteLine(" Марка " + Mark + "\n Модель " + Model + "\n Год " + Ans + "\n Цвет " + Color + "\n Цена " + Prix + '\n');
            }
        }
        public class VVVV
        {
            public List<Voiture> VG = new List<Voiture>();
            public void AddVoiture(Voiture VV)
            {
                VG.Add(VV);
            }
            public void RemoveVoiture()
            {
                Console.WriteLine("Введите марку автомобиля : ");
                string? a11 = Convert.ToString(Console.ReadLine());
                var VAVA = VG.Where(s => s.Mark == a11).Select(s => s);
                int a = 0;
                foreach(var VA in VAVA)
                {
                    ++a;Console.WriteLine(a);
                    VA.Mostrare();
                }
                Console.WriteLine("Введите номер автомобиля : ");
                int a22 = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                --a;
                foreach(var V in VAVA) {
                    if (i==a)
                    {
                        VG.Remove(V);
                        Console.WriteLine("Автомобиль удален ");
                        break;
                    }
                }
                
            }
            public void NewVoiture()
            {
                Console.WriteLine("Введите марку ");
                string ?a1 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите модель ");
                string ?a2 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите год ");
                int a3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите цвет ");
                string? a4 = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите цену ");
                int a5 = Convert.ToInt32(Console.ReadLine());
                Voiture VVU = new Voiture { Mark = a1, Model = a2, Ans = a3, Color = a4, Prix = a5 };
                AddVoiture(VVU);
                Console.WriteLine("Автомобиль создан");
            }
            public void Mostra()
            {
                int F = 0;
                foreach(var EE in VG)
                {
                    ++F;
                    Console.WriteLine(F);
                    EE.Mostrare();
                }
            }
            public void Redact()
            {
                Mostra();
                Console.WriteLine("Введите номер автомобиля ");
                int bb = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите параметр изменения ");
                string? bb2 = Convert.ToString(Console.ReadLine());
                int s = 0;
                foreach (var E in VG) {
                    ++s;
                    if (s == bb)
                    {
                        switch (bb2)
                        {
                            case "Mark":Console.WriteLine("Введите марку ");
                                string? bbb = Convert.ToString(Console.ReadLine());E.Mark = bbb;

                                ; break;
                            case "Model":
                                Console.WriteLine("Введите модель ");
                                string? bbb1 = Convert.ToString(Console.ReadLine()); E.Model = bbb1 ; break;
                            case "Ans":
                                Console.WriteLine("Введите год ");
                                int bbb2 = Convert.ToInt32(Console.ReadLine()); E.Ans = bbb2; break;
                            case "Prix":
                                Console.WriteLine("Введите Цену ");
                                int bbb3 = Convert.ToInt32(Console.ReadLine()); E.Prix = bbb3;
                                ; break;
                            case "Color":
                                Console.WriteLine("Введите цвет ");
                                string? bbb4 = Convert.ToString(Console.ReadLine()); E.Color = bbb4; ; break;
                            default: break;
                        }
                    }
                }

               
            }
            public void Mark(string M)
            {
                var DADA = VG.Where(s => s.Mark == M).Select(s => s);
                foreach(var D in DADA)
                {
                    D.Mostrare();
                }
            }
            public void Model(string Mod)
            {
                var DADA1 = VG.Where(s => s.Model == Mod).Select(s => s);
                foreach (var D in DADA1)
                {
                    D.Mostrare();
                }
            }
            public void Prix(int a,int b)
            {
                var DADA2 = VG.Where(s => s.Prix <= a && s.Prix >= b).Select(s => s);
                foreach (var D in DADA2)
                {
                    D.Mostrare();
                }
            }

        }

        static void Main(string[] args)
        {
            //Product product1 = new Product { ProductID = 123445, ProductName = "Салат", ProductPrice = 230 };
            //Product product2 = new Product { ProductID = 344543, ProductName = "Виски", ProductPrice = 13000 };
            //Product product3 = new Product { ProductID = 435642, ProductName = "Конфеты", ProductPrice = 670 };
            //Customer cust1 = new Customer { CustomerID = 23452, CustomerAdress = "AAA,123", CustomerName = "Alex" };
            //Customer cust2 = new Customer { CustomerID = 56345, CustomerAdress = "BBB,654", CustomerName = "Vera" };
            //Customer cust3 = new Customer { CustomerID = 13435, CustomerAdress = "CCC,901", CustomerName = "Olga" };
            //Order order1 = new Order { Customer = cust1.CustomerName, OrderID = 1111, OrderDateTime = new DateTime(2023, 12, 12), ListOfProducts = new List<Product> { product1, product2 } };
            //Order order2 = new Order { Customer = cust2.CustomerName, OrderID = 1112, OrderDateTime = new DateTime(2023, 12, 13), ListOfProducts = new List<Product> { product1, product3 } };
            //Order order3 = new Order { Customer = cust3.CustomerName, OrderID = 1113, OrderDateTime = new DateTime(2023, 12, 14), ListOfProducts = new List<Product> { product2, product2,product2 } };
            //Store SSTO = new Store();
            //SSTO.AddOrder(order1);
            //SSTO.AddOrder(order2);
            //SSTO.AddOrder(order3);
            //SSTO.ProcessOrders();
            //order1.OrderProcessed += OrPro;
            //order2.OrderProcessed += OrPro;
            //order3.OrderProcessed += OrPro;

            Voiture vv1 = new Voiture { Mark = "aaaa", Model = "a1a1a1", Ans = 1997, Color = "black", Prix = 200000 };
            Voiture vv2 = new Voiture { Mark = "bbbb", Model = "b1b1b1", Ans = 1997, Color = "black", Prix = 333333 };
            Voiture vv3 = new Voiture { Mark = "cccc", Model = "a1a1a1", Ans = 1998, Color = "black", Prix = 800000 };
            Voiture vv4 = new Voiture { Mark = "dddd", Model = "c1c1c1", Ans = 2001, Color = "black", Prix = 340000 };

            VVVV VOT = new VVVV();
            VOT.AddVoiture(vv1);
            VOT.AddVoiture(vv2);
            VOT.AddVoiture(vv3);
            VOT.AddVoiture(vv4);
            VOT.Mostra();
            VOT.RemoveVoiture();
            VOT.NewVoiture();
            VOT.Model("a1a1a1");
            VOT.Redact();
            VOT.Mostra();

        }
        private static void OrPro(Order or)
        {
            Console.WriteLine("PPP");
        }
    }
}