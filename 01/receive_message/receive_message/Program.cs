using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace receive_message
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入
            /*
            string name;
            Console.Write("请输入姓名：");
            name = Console.ReadLine();//接收用户输入的一个字符串
            Console.WriteLine("你好，{0}",name);
            */

            string[] name = new string[2];//姓名数组
            int[] score = new int[2];//分数数组

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("请输入第"+(i+1)+"位同学的姓名：");
                name[i] = Console.ReadLine();
                Console.Write("请输入第" + (i + 1) + "位同学的分数：");
                score[i] = int.Parse(Console.ReadLine());
            }

            //计算总分和平均值
            int sum=0, avg;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }

            avg = sum / score.Length;

            Console.WriteLine("总分是：{0}，平均分是：{1}",sum,avg);
        }
    }
}
