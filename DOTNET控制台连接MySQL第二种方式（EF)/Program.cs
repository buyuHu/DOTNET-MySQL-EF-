using System;
using System.Linq;

namespace DOTNET控制台连接MySQL第二种方式_EF_
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new schoolEntities();
            var text = new test();
            text.id = 2;
            text.name = "fang";
            db.test.Add(text);
            db.SaveChanges();
            var table = from a in db.test
                        where a.id == 1
                        select a;
            Console.WriteLine(table.FirstOrDefault().id);

        }
    }
}
