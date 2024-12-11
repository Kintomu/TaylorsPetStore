using PetStore.Data.Models;

namespace TaylorsPetStore.Extensions
{
    public static class ListExtensions
    {
        internal static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return list.Where(x => x.Quantity > 0).ToList();
        }
    }
}
