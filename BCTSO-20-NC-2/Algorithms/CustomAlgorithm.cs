using Algorithms.Models;

namespace Algorithms
{
    public static class CustomAlgorithm
    {
        public static T FirstOrDefault<T>(IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return default;
        }
        public static IEnumerable<T> NikasForeach<T>(IEnumerable<T> sources)
        {
            var sourceEnumerator = sources.GetEnumerator();

            while (sourceEnumerator.MoveNext())
            {
                yield return sourceEnumerator.Current;
            }
        }
        public static T LastOrDefault<T>(IEnumerable<T> source, Func<T, bool> predicate)
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
        public static IEnumerable<T> Where<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }


        //public static T[] OrderBy<T>(T[] list) where T : IComparable<T>
        //{
        //    for (int i = 0; i < list.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < list.Length; j++)
        //        {
        //            if (list[j].CompareTo(list[i]) == -1)
        //            {
        //                T temp = list[j];
        //                list[j] = list[i];
        //                list[i] = temp;
        //            }
        //        }
        //    }

        //    return list;
        //}

        public static IList<T> OrderBy<T>(IList<T> list, Func<T, T, bool> comparerFunction)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (comparerFunction(list[j], list[i]))
                    {
                        T temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }
            }

            return list;
        }
        public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var item in source)
            {
                yield return selector(item);
            }
        }


        public static int IndexOf<T>(T[] collection, Func<T, bool> predicate)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (predicate(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        public static int IndexOf<T>(List<T> collection, Func<T, bool> predicate)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (predicate(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public static int LastIndexOf<T>(T[] collection, Func<T, bool> predicate)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (predicate(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        public static int LastIndexOf<T>(List<T> collection, Func<T, bool> predicate)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (predicate(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public static int Sum(int[] collection)
        {
            int result = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                result += collection[i];
            }

            return result;
        }
        public static int Sum(List<int> collection)
        {
            int result = 0;

            for (int i = 0; i < collection.Count; i++)
            {
                result += i;
            }

            return result;
        }

        public static int Sum(int[] collection, Func<int, bool> predicate)
        {
            int result = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                if (predicate(collection[i]))
                {
                    result += collection[i];
                }
            }

            return result;
        }
        public static int Sum(List<int> collection, Func<int, bool> predicate)
        {
            int result = 0;

            for (int i = 0; i < collection.Count; i++)
            {
                if (predicate(collection[i]))
                {
                    result += collection[i];
                }
            }

            return result;
        }

        public static T Max<T>(List<T> intList) where T : IComparable<T>
        {
            T max = intList[0];

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i].CompareTo(max) > 0)
                {
                    max = intList[i];
                }
            }

            return max;
        }
        public static T Min<T>(List<T> intList) where T : IComparable<T>
        {
            T min = intList[0];

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i].CompareTo(min) < 0)
                {
                    min = intList[i];
                }
            }

            return min;
        }


        //public static T Max<T>(List<T> intList, Func<T, T, bool> selector)
        //{
        //    T max = intList[0];

        //    for (int i = 0; i < intList.Count; i++)
        //    {
        //        if (selector(intList[i], max))
        //        {
        //            max = intList[i];
        //        }
        //    }

        //    return max;
        //}


        public static T[] Take<T>(T[] collection, int count)
        {
            T[] result = new T[count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = collection[i];
            }

            return result;
        }
        public static List<T> Take<T>(List<T> collection, int count)
        {
            List<T> result = new();

            for (int i = 0; i < result.Count; i++)
            {
                result.Add(collection[i]);
            }

            return result;
        }


        public static bool Any<T>(List<T> collection, Func<T, bool> predicate)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (predicate(collection[i]))
                {
                    return true;
                }
            }

            return false;
        }
        public static bool All<T>(List<T> collection, Func<T, bool> predicate)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (!predicate(collection[i]))
                {
                    return false;
                }
            }

            return true;
        }


        public static List<T> Reverse<T>(List<T> collection)
        {
            Stack<T> stack = new();

            for (int i = 0; i < collection.Count; i++)
            {
                stack.Push(collection[i]);
            }

            return stack.ToList();
        }




        //TODO Union
        //TODO Intersect

    }
}
