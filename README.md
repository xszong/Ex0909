# Ex0909

这段 C# 程序的主要功能是：

用户输入一个 1~100 的整数，然后程序通过 Lambda 表达式计算该数的平方并显示出来。

下面是对代码逐行的中文解释，帮助你更清楚理解每一步在干什么：


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
 引入所需的命名空间，using static System.Console 让你可以直接用 WriteLine() 等方法，而不需要写 Console.WriteLine()。


namespace Ex0909
{
   class Program
🔸 定义命名空间和类 Program，所有代码都包含在这个类中。


//1.宣告委派
delegate int Appoint(int i);
🔸 声明一个委托类型 Appoint，它接受一个 int 参数，返回一个 int。你可以理解成定义了一种“函数签名”的类型。

static void Main()
{
🔸 主程序入口。


Write("請輸入1~100數值：");
int num = int.Parse(ReadLine());
🔸 提示用户输入一个 1~100 的整数，并将其转换成整数 num。


if (num > 100 || num < 1)
    WriteLine("數值不對");
🔸 如果输入不在范围 1~100 之间，提示“数值不对”。

else
{
   //2.Lambda運算式取代委派方法；3.宣告委派物件deputation 
   Appoint deputation = number => number * number;
🔸 如果输入合法：

用 Lambda 表达式 (number => number * number) 定义了一个函数：输入一个整数，返回其平方；

把这个函数赋值给 Appoint 类型的变量 deputation（委托对象）。

   //4.呼叫委派
   WriteLine($"運算結果：{deputation(num):n0}");
}
🔸 调用 deputation(num)，就是执行平方计算，并用格式化方式输出结果（n0 表示带千位分隔符的整数格式）。

ReadKey();
🔸 等待用户按任意键后关闭程序窗口。

✅ 示例运行：

請輸入1~100數值：25
運算結果：625
🔍 总结重点知识：
项目	说明
委托 (delegate)	一种可以指向方法的类型（类似函数指针）
Lambda 表达式	用来简洁地定义一个匿名函数
Appoint	自定义的委托类型，接受一个 int 返回 int
number => number * number	匿名函数，返回平方

如果你想要练习扩展这段代码，也可以试试：

改为计算立方；

判断输入是否为整数；

支持用户连续输入多次。
