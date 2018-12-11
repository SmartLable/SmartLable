using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入打招呼的语言");
            Program pr = new Program();
                pr.S();
            string Sayw = Console.ReadLine();

          SayHello sh =   GetSayHello(Sayw);

            if (sh != null)
            {
                sh.Sayhello();


            }
            else
                Console.WriteLine("输入有误");

            Console.ReadKey();

        }

        public static SayHello GetSayHello (string sw)
        {
            SayHello sh = null;
            switch (sw)
            {
                case "你好":
                    sh = new SayChiness();
                    break;
                case "Hello":
                    sh = new SayEnglish();
                    break;

                default:
                    break;

            }

            return sh;

        }



        public void S()   // 非静态方法 需要实列化 才能使用  
        {

            Console.WriteLine("请开始输入");
        }
        public abstract class SayHello
        {

            public abstract void Sayhello();
           
        }


       public class SayChiness :SayHello

        {

            public override void Sayhello()
            {

                Console.WriteLine("你好");

            }
        }

        public class SayEnglish:SayHello
        {
            public override void Sayhello()
            {
                Console.WriteLine("Hello ");
            }

        }

    }
}
