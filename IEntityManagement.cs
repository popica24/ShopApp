using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    interface IBaseOperations<T>
    {
        bool Equals(object a);
        void Add(T a);
        void Remove(T a);
        T Search(T a);
        bool CheckDuplicate(T a);
    }

}
