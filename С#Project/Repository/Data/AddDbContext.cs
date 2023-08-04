using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    internal static class AddDbContext<T>
    {
        public static List<T> datas;

        static AddDbContext()
        {
            datas = new List<T>();
        }
   
    }
}
