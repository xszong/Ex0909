using System; // 引入基本命名空间，提供控制台输入输出、数据类型转换等功能
using System.Collections.Generic; // （当前程序未用到）支持泛型集合，如 List、Dictionary 等
using System.Linq; // （当前程序未用到）提供 LINQ 语言集成查询功能
using System.Text; // （当前程序未用到）用于处理字符编码、字符串操作等
using System.Threading.Tasks; // （当前程序未用到）支持异步处理（任务并发等）
using static System.Console; // 静态导入 Console 类，让你可以直接使用 WriteLine() 等方法，无需写 Console.WriteLine()

namespace Ex0909 // 定义一个命名空间，组织代码结构，防止命名冲突
{
    class Program // 定义主类 Program，C# 程序从这里开始运行
    {
        // 1. 宣告委派（Delegate）
        delegate int Appoint(int i); // 声明一个委托类型，接收一个 int 参数并返回 int，用于引用满足此签名的方法或表达式
        static void Main() // 主程序入口
        {
            Write("請輸入1~100數值："); // 提示用户输入一个 1 到 100 的整数（中文提示，适合中文用户）

            int num = int.Parse(ReadLine()); // 读取用户输入并将其转换为整数，赋值给变量 num
            if (num > 100 || num < 1) // 判断用户输入是否超出有效范围
                WriteLine("數值不對"); // 若超出范围，则输出提示信息

            else
            {
                // 2. 使用 Lambda 表达式取代委派方法
                // 3. 创建委托变量 deputation，并赋值为匿名函数（Lambda）
                Appoint deputation = number => number * number;
                // 4. 调用委托变量，传入用户输入的数字，并将结果格式化输出
                WriteLine($"運算結果：{deputation(num):n0}");
            }

            ReadKey(); // 等待用户按任意键，防止程序窗口一闪而过（用于调试或命令行显示）
        }
    }
}
