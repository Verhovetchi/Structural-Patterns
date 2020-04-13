using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
     class AdapterAppToDB:App, IDataBase
     {
          public void insert()
          {
               SaveObject();
          }
          public void update()
          {
               UpdateObject();
          }

          public void remove()
          {
               DeleteObject();
          }

          public void select()
          {
               LoadObject();
          }
     }
}
