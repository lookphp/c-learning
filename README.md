## c-learning
learn c#
first class content
new a project step:<br/>
1、选择文件类型：文件->新建项目->模板->Visual c# ->Windows-> 控制台应用程序（用于创建命令行应用程序的项目）<br/>
2、填写文件名称和文件存储位置：名称->myfirstapp 位置：D:\c#\c-learning\01\<br/>
3、c#源文件是以 .cs  结尾的

##认识c#程序结构
需要记住的4点：
1、Main方法，是程序的入口<br/>
2、在命名空间中包含了若干类，命名空间是用来组织和管理类的<br/>
3、c#是由类组成的，类是c#的最小组成单元，声明类的关键字是class<br/>
4、输出语句：Console.Write();<br/>

##在控制台接收、输入
接收输入：Console.ReadLine();<br>
接收的类型是：string类型<br>
接收到int类型时，需要转换类型：int.Parse(Console.ReadLine());
##在c#中进行断点跟踪及调试
设置断点：F9<br>
调试：F5<br>
单步执行：F10<br>

###步骤：
1、在容易出错的代码行按F9快捷键，设置断点。<br>
2、调试，按下F5，执行控制台程序<br>
3、单步执行，查看局部变量的变化
