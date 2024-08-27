using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorsPetStore
{
    public static class ListExtensions
    {
        internal static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return list.Where(x => x.Quantity > 0).ToList();
        }
    }
}
