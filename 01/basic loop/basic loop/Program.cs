using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_loop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /**
            *1、嵌套循环，在一个循环体中包含另一个循环
            *当2个循环嵌套的时候，外层循环体执行一次，内层循环体执行n次（n是内层循环的次数）
            */
            /*
            for (int i = 1; i <= 7; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    Console.Write(x);
                }
                //Console.Write('-');
                //Console.WriteLine(i);
                Console.WriteLine();
            }
            */


            //2、算法---输出特殊的图像
            /*
            for (int x = 1; x<=7; x++)
            {
                for (int y=1; y<= 7; y++)
                {
                    if (x == y || x + y == 8)
                    {
                        Console.Write('o');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
            */

            //3、数组--数组的声明和初始化。
            /*
            string[] names = new string[3];
            names[0] = "吴彦祖";
            names[1] = "谢雨婷";
            names[2] = "周杰杰";
            Console.Write(names[0] + "");
            Console.Write(names[1] + "");
            Console.Write(names[2] + "");
            Console.WriteLine(names.Length);
            Console.WriteLine("我有{0}个好朋友！",names.Length);
            */


            //4、数组的多种初始化方式
            //数组在初始化时就为数组元素指定初始值

            //数组+length+for循环的知识点
            /*
            string[] names = new string[3];
            names[0] = "吴彦祖";
            names[1] = "谢雨婷";
            names[2] = "周杰杰";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]+"----");
            }
            */


            /*5、foreach输出数组元素*/

            /*
            string[] t = new string[] { "C", "Sh", "a", "rp" };
            //遍历字符串数组t
            foreach (string x in t)
            {
                Console.Write(x);
            }
            */


            //6、查找其中有没有7的整倍数
            //声明整型数组，保存一组整数
            /*
            int[] num = new int[] { 3, 34, 43, 2, 11, 19, 30, 55, 20 };
            //请完善代码，判断数组中有没有7的整倍数

            bool has7 = false;//记录有没有7的整倍数，假设没有
            foreach (int x in num)//遍历每一个数字
            {
                if (x % 7 == 0)//设置筛选条件，查找7的整倍数
                {
                    has7 = true;//找到后，记录为true，即“有7的整倍数”
                    break;//跳出foreach，结束查找
                }
            }

            //判断结果并输出
            if (has7)
            {
                Console.Write("7的整倍数");
            }
            else
            {
                Console.Write("没有7的整倍数");
            }
            */


            //二维数组
            //int[,] arr = new int[2, 3];
            //arr[1, 0] = 28;
            //Console.Write(arr[1,0]);

            //int[,] score = new int[4, 2] { { 89,86}, { 69,40}, { 64,92}, { 82,100} };
            //Console.WriteLine("同学们的分数是：");
            //for (int i = 0; i < score.GetLongLength(0); i++)
            //{
            //    Console.WriteLine("语文：{0},数学：{1}",score[i,0],score[i,1]);
            //}

            //char[,] ch = { { '我', '是', '软' }, { '件', '工', '程' }, { '师', '啦', '！' } };
            //Console.WriteLine("{0}{1}{2}", ch[1,1], ch[1,2], ch[2,0]);

            string[] name = new string[] { "吴松","钱东宇","伏晨","陈露","周蕊","林日鹏","何昆","关欣"};
            int[] score = new int[] { 89,90,98,56,60,91,93,85};

        }
    }
}
