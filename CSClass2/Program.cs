using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    //예외처리
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("입력 : ");
            string input = Console.ReadLine();

            try
            {
                int index = int.Parse(input);
                Console.WriteLine("입력 숫자 : " + index);
            }
            catch (Exception ex)
            {
                Console.WriteLine("예외발생");
                Console.WriteLine(ex.GetType());
                return;
            }
            finally
            {
                Console.WriteLine("프로그램이 종료됨");
            }
        }
    }

    //인터페이스
    /*class TestClass : IBasic
    {
        public int TestInstanceMethod()
        {
            throw new NotImplementedException();
        }
        public int TestProperty
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
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
            
            IBasic basic = new TestClass();

            Child c = new Child();
            Parent childAsParent = c;
            IDisposable childAsDispoable = c;
            IComparable<Child> childAsComparable = c;

            File.WriteAllText(@"c:\TEMP\test.txt", "문자열 메시지를 씁니다");
            Console.WriteLine(File.ReadAllText(@"c:\TEMP\test.txt"));

            using (StreamWriter writer = new StreamWriter(@"c:\temp\test.txt"))
            {
                writer.WriteLine("안녕하세요.");
                writer.WriteLine("StreamWriter 클래스를 사용해서");
                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine("반복문 - " + i);
                }
            }
            //Console.WriteLine(File.ReadAllText(@"c:\TEMP\test.txt"));
            using (StreamReader reader = new StreamReader(@"c:\temp\test.txt"))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }*/


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
