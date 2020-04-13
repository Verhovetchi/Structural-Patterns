using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
     class App
     {
          public void SaveObject()
          {
               Console.WriteLine("Save object");
          }

          public void UpdateObject()
          {
               Console.WriteLine("Update object");
          }
          public void LoadObject()
          {
               Console.WriteLine("Load object");
          }
          public void DeleteObject()
          {
               Console.WriteLine("Delete object");
          }
     }
}
