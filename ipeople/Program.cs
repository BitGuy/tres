using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipeople
{
    class Program
    {
        static void Main(string[] args)
        {
            mypoint mp = new mypoint(35, 160);
            print(mp);
            Console.Read();
        }
        private static void print(ipeople ip)
        {
            Console.WriteLine("体重:{0},身高:{1}\n", ip.w, ip.h);
        }
    }
    public interface ipeople
    {
        int w
        {
            get;
            set;
        }
        int h
        {
            get;
            set;
        }
    }
    class mypoint : ipeople
    {
        private int myw;
        private int myh;
        public mypoint(int w, int h)
        {
            myw = w;
            myh = h;
        }
        public int w
        {
            get { return myw; }
            set { myw = value; }
        }
        public int h
        {
            get { return myh; }
            set { myh = value; }
        }
    }
}
