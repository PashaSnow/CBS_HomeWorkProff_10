using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionAND_task2
{
    abstract class A
    {
        public void TempledMethod()
        {
            Meth1();
            Meth2();
        }
        protected abstract void Meth1();
        protected virtual void Meth2()
        {
            Console.WriteLine("Abstract class");
        }
    }
    sealed class B : A
    {
        protected override void Meth1()
        {
            Console.WriteLine("Abstract method1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A instance = new B();
            instance.TempledMethod();
        }
    }
}
