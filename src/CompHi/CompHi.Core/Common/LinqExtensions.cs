using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompHi.Core.Common
{
    public static class LinqExtensions
    {



        public static IEnumerable<T> Flatten1<T>(this T root, Func<T, IEnumerable<T>> getChildernFunc)
        {
            yield return root;

            IEnumerable<T> descendants = getChildernFunc(root);
            if (descendants != null)
                foreach (T element in descendants)
                {
                    foreach (T elementinner in element.Flatten1(getChildernFunc))
                    {
                        yield return elementinner;
                    }
                }
        }






        public static IEnumerable<T> Flatten<T>(this IEnumerable<T> source, Func<T, IEnumerable<T>> childPropertySelector)
        {
            return source
                .Flatten((itemBeingFlattened, objectsBeingFlattened) =>
                    childPropertySelector(itemBeingFlattened));
        }


        public static IEnumerable<T> Flatten<T>(this IEnumerable<T> source, Func<T, IEnumerable<T>, IEnumerable<T>> childPropertySelector)
        {
            return source
                .Concat(source
                .Where(item => childPropertySelector(item, source) != null)
                .SelectMany(itemBeingFlattened =>
                    childPropertySelector(itemBeingFlattened, source)
                        .Flatten(childPropertySelector)));
        }
    }
}
