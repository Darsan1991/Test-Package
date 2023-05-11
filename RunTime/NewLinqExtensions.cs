using System.Collections.Generic;
using System.Linq;

namespace DGames.Utils
{
    public static class NewLinqExtensions
    {
        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return !enumerable.Any();
        }
    }
}