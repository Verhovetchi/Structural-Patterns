using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
     public interface IDataBase
     {
          void insert();
          void update();
          void remove();
          void select();
     }
}
