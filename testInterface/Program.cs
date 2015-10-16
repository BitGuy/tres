using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            狗 旺财 = new 狗();
            旺财.叫();
            猫 麦 = new 猫();
            麦.叫();
            Console.ReadKey();
        }
    }
    public interface 动物叫
    {
        void 叫();
    }
    public class 狗 : 动物叫
    {
        public void 叫()
        {
            Console.WriteLine("汪!汪!");
        }
    }
    public class 猫 : 动物叫
    {
        public void 叫()
        {
            Console.WriteLine("喵喵!");
        }
    }
}
