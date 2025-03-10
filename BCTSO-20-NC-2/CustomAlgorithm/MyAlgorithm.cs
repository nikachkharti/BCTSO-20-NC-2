﻿namespace CustomAlgorithm
{
    public static class MyAlgorithm
    {
        public static T MyFirstOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return default;
        }
        public static T MyLastOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            T result = default;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result = item;
                }
            }

            return result;
        }
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
        public static IEnumerable<T> MyForeach<T>(this IEnumerable<T> source)
        {
            var enumerator = source.GetEnumerator();

            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }
        public static int MyIndexOf<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            int i = 0;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return i;
                }

                i++;
            }

            return -1;
        }
        public static int MyLastIndexOf<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            int i = default;
            int result = -1;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result = i;
                }

                i++;
            }

            return result;
        }
        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var item in source)
            {
                yield return selector(item);
            }

            //TResult[] result = new TResult[source.Length];

            //for (int i = 0; i < source.Length; i++)
            //{
            //    result[i] = selector(source[i]);
            //}

            //return result;
        }
        public static IList<T> MyOrderBy<T>(this IList<T> result, Func<T, T, bool> compareFunction)
        {
            for (int i = 0; i < result.Count - 1; i++)
            {
                for (int j = i + 1; j < result.Count; j++)
                {
                    if (compareFunction(result[j], result[i]))
                    {
                        T temp = result[j];
                        result[j] = result[i];
                        result[i] = temp;
                    }
                }
            }

            return result;
        }
        public static int MySum(this IEnumerable<int> source)
        {
            int result = 0;

            foreach (var item in source)
            {
                result += item;
            }

            return result;
        }
        public static int MySum(this IEnumerable<int> source, Func<int, bool> predicate)
        {
            int result = 0;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result += item;
                }
            }

            return result;
        }
        public static IEnumerable<T> MyDistinct<T>(this IEnumerable<T> source)
        {
            HashSet<T> set = new();

            foreach (var item in source)
            {
                set.Add(item);
            }

            return set;
        }
        public static IEnumerable<T> MyDistinct<T>(this IEnumerable<T> source, IEqualityComparer<T> comparer)
        {
            HashSet<T> set = new(comparer);

            foreach (var item in source)
            {
                set.Add(item);
            }

            return set;
        }
        public static IEnumerable<T> MyReverse<T>(this IEnumerable<T> source)
        {
            Stack<T> stack = new();

            foreach (var item in source)
            {
                stack.Push(item);
            }

            return stack;
        }
        public static IEnumerable<T> MyReverse<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            Stack<T> stack = new();

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    stack.Push(item);
                }
            }

            return stack;
        }
        public static bool MyAny<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool MyAll<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }

            return true;
        }
        public static T MyMax<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            using var enumerator = source.GetEnumerator();

            if (!enumerator.MoveNext())
            {
                throw new ArgumentException("Source cannot be empty", nameof(source));
            }

            T max = enumerator.Current;

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.CompareTo(max) > 0)
                {
                    max = enumerator.Current;
                }
            }

            return max;
        }
        public static T MyMin<T>(this IEnumerable<T> source) where T : IComparable<T>
        {
            using var enumerator = source.GetEnumerator();

            if (!enumerator.MoveNext())
            {
                throw new ArgumentException("Source cannot be empty", nameof(source));
            }

            T min = enumerator.Current;

            while (enumerator.MoveNext())
            {
                if (enumerator.Current.CompareTo(min) < 0)
                {
                    min = enumerator.Current;
                }
            }

            return min;
        }

        //TODO Union
        //TODO Intersect
    }
}
