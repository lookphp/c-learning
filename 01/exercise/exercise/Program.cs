using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    /**
    *思路：1、所有的分数全都要查看一遍（for循环）
    *      2、然后比较他们的大小，找到最大的(if判断)
    *      3、因为名字和分数的索引下标是一一对应的，所以找到最大的分数的下标，就能通过下标找到名字（下标）
    *      4、通过下标找到名字
    */     
    class Program
    {
        static void Main(string[] args)
        {

            //方法一：
            /*
            string[] names = new string[] { "吴松","钱东宇","伏晨","陈陆","周蕊","林日鹏","何昆","关欣"};
            int[] score = new int[] { 89,90,98,56,60,91,93,85};
            int max = score[0];
            string name = names[0];
            //寻找最高分
            for (int i = 0; i < score.Length; i++)
            {
                //Console.WriteLine(score[i]);
                
                if (score[i] > max)
                {
                    max = score[i];
                    name = names[i];//寻找最高分对应的索引下标
                }
            }

            Console.WriteLine("分数最高的是"+name+"，分数是"+max);
            */

            //网上的同学做的
            int i, k, max;
            string[] names = new string[] { "吴松", "钱东宇", "伏晨", "陈陆", "周蕊", "林日鹏", "何昆", "关欣" };
            int[] score = new int[] { 89, 90, 98, 56, 60, 91, 93, 85 };
            k = 0;
            max = score[0];
            for (i=1;i<score.Length;i++)
            {
                if (score[i] > max)
                {
                    max = score[i];//找到最高分
                    k = i;  //把最高分的元素下标分配给k
                }
            }

            Console.WriteLine("分数最高的是{0}，分数是{1}",names[k],score[k]);
        }
    }
}
