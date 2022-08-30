using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    //인터페이스
    class Dummy : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose() 메서드를 호출했습니다.");
        }
    }
    class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }

        public int CompareTo(Product other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            using(Dummy dummy = new Dummy())
            {
                List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마", Price = 1500 },
                new Product() { Name = "사과", Price = 2400 },
                new Product() { Name = "바나나", Price = 1000 },
                new Product() { Name = "배", Price = 3000 }
            };
                //list.Sort();

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }


    //구조체
    /*struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point;
            point.x = 10;
            point.y = 10;

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }*/


    /*class Wanted<T>
    {
        public T Value; public Wanted(T value)
        {
            this.Value = value;
        }
    }

    class SquareCalculator
    {
        public int this[int i]
        {
            get
            {
                return i * i;
            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("String"); 
            Wanted<int> wantedInt = new Wanted<int>(52273); 
            Wanted<double> wantedDouble = new Wanted<double>(52.273);
            Console.WriteLine(wantedString.Value); Console.WriteLine(wantedInt.Value); 
            Console.WriteLine(wantedDouble.Value);


            SquareCalculator square = new SquareCalculator(); 
            Console.WriteLine(square[10]);


            Console.WriteLine("숫자 입력 : ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("입력한 숫자 : " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요");
            }

            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;

            Console.WriteLine("현재 좌표 : (" + x + ", " + y + ")");
            NextPos(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표 : (" + x + ", " + y + ")");
        }

        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }
    }*/
}
