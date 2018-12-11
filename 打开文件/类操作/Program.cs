using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"D:\a");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();



            //try
            //{
            //    Directory.Delete(@"D:\a",true);
            //    Console.WriteLine("删除成功");
            //    Console.ReadKey();
            //}
            //catch(Exception ex)
            //{

            //    Console.WriteLine(ex.ToString());
            //    Console.ReadKey();
            //}

            //剪切
            //Directory.Move(@"C:\a", @"C:\Users\Administrator\Desktop\new1");
            //Console.WriteLine("剪切成功");
            //Console.ReadKey();

            Test ts = new Test('3');
            ts.name = "李四";
            Console.WriteLine(ts.name);
            Console.WriteLine(ts.sex);
            Console.ReadKey();
        }



        public class Test
        {

            string _name;
            public string name
            {

                get
                {


                    return _name;
                }
                set
                {
                    if (value != "张三")
                        value = "张三";
                    _name = value;
                }
            }

            public char sex { set; get; }

            public int age { set; get; }

            public Test(char sex)
            {

                if (sex != '男' & sex != '女')
                {

                    this.sex = '男';

                }
                else
                    this.sex = sex;

            }

        }





    }
}
