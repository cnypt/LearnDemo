using System;
using System.Diagnostics;
using System.Reflection;

namespace 获取当前方法所在的命名空间
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetMethodInfo());

            Console.ReadKey();
        }

        private static string GetMethodInfo()
        {
            string str = "";
            //取得当前方法命名空间
            str += "命名空间名:" + MethodBase.GetCurrentMethod().DeclaringType.Namespace + "\n";
            //取得当前方法类全名
            str += "类名:" + MethodBase.GetCurrentMethod().DeclaringType.FullName + "\n";
            //取得当前方法名
            str += "方法名:" + MethodBase.GetCurrentMethod().Name + "\n";
            str += "\n";

            StackTrace ss = new StackTrace(true);
            MethodBase mb = ss.GetFrame(1).GetMethod();
            //取得父方法命名空间
            str += mb.DeclaringType.Namespace + "\n";
            //取得父方法类名
            str += mb.DeclaringType.Name + "\n";
            //取得父方法类全名
            str += mb.DeclaringType.FullName + "\n";
            //取得父方法名
            str += mb.Name + "\n";
            return str;
        }
    }
}
