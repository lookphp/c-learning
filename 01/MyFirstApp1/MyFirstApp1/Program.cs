using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//命名空间
namespace MyFirstApp1
{
    //类
    class Program
    {

        //1、Main方法，程序入口
        static void Main(string[] args) 
        {
            Console.WriteLine(1>=1);

            int x = 5;
            int y = 5;
            int z = 5;
            x++;
            Console.Write(x);
            Console.Write(++y);
            Console.Write(++z);

            string job = "工程师";
            bool isRightMan;//是否为理想的男友
            isRightMan = (job == "工程师" || job == "运动员");
            Console.WriteLine(isRightMan);

            double salary = 6000.00;//基本工资
            double prize = 3200.00;//奖金
            double tax = 4500.00;//交税
            Console.WriteLine("我的工资奖金总额是{0}元", salary + prize);
            Console.WriteLine("我的税后收入是{0}元", salary + prize - tax);

            //double d = 2.5;
            //int x = (int)d + 1;
            //Console.WriteLine(x);

            //一个测试题，结果为21岁
            int age;
            age = 18;
            age = 20;
            age = 20 + 1;
            Console.WriteLine("我今年{0}岁",age);
            age = age - 2;

            //3、输出语句
            Console.Write("hello world");   //不换行
            Console.WriteLine("世界，你好");//在打印之后换行
                                            //命令，以分号结束
                                            //调试：f5
                                            //不调试，直接运行：ctrl +f5
                                            //类是c#的最小组成单元
                                            //命名空间是用来组织和管理类
                                            //2、在命名空间MyFirstApp1 中包含了program的类，也可以包含其他类
        }
    }
}
