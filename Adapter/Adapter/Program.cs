using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
     class Program
     {
          static void Main(string[] args)
          {
               IDataBase dataBase = new AdapterAppToDB();
               
               dataBase.select();
               dataBase.insert();
               dataBase.update();
               dataBase.remove();
             
               Console.ReadKey();
          }
     }
}
