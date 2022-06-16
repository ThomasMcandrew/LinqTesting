
namespace System.Linq
{
    public static class Enumerable2
    {
        public static IEnumerable<TSource> If<TSource>(this IEnumerable<TSource> source,
            Func<IEnumerable<TSource>, bool> predicate,
            Func<IEnumerable<TSource>, IEnumerable<TSource>> thenPredicate,
            Func<IEnumerable<TSource>, IEnumerable<TSource>>? elsePredicate = null)
        {
            if(predicate(source))
            {
                return thenPredicate(source);
            }
            else if(elsePredicate == null)
            {
                return source;
            }
            else
            {
                return elsePredicate(source);
            }
        }
        public static IEnumerable<TSource> If<TSource>(this IEnumerable<TSource> source,
            bool predicate,
            Func<IEnumerable<TSource>, IEnumerable<TSource>> thenPredicate,
            Func<IEnumerable<TSource>, IEnumerable<TSource>>? elsePredicate = null)
        {
            if(predicate)
            {
                return thenPredicate(source);
            }
            else if(elsePredicate == null)
            {
                return source;
            }
            else
            {
                return elsePredicate(source);
            }
        }
    }
}