using Algorithms.Models;

namespace Algorithms
{
    public static class CustomAlgorithm
    {
        public static T FirstOrDefault<T>(T[] collection, Predicate<T> predicate)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (predicate(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static T FirstOrDefault<T>(List<T> collection, Predicate<T> predicate)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (predicate(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }

        public static T LastOrDefault<T>(List<T> collection, Func<T, bool> predicate)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (predicate(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static T LastOrDefault<T>(T[] collection, Func<T, bool> predicate)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (predicate(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }

        public static List<T> Where<T>(List<T> collection, Func<T, bool> predicate)
        {
            List<T> result = new();

            for (int i = 0; i < collection.Count; i++)
            {
                if (predicate(collection[i]))
                {
                    result.Add(collection[i]);
                }
            }

            return result;
        }
        public static T[] Where<T>(T[] collection, Func<T, bool> predicate)
        {
            List<T> result = new();

            for (int i = 0; i < collection.Length; i++)
            {
                if (predicate(collection[i]))
                {
                    result.Add(collection[i]);
                }
            }

            return result.ToArray();
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


        public static T[] OrderBy<T>(T[] array, Func<T, T, bool> comparerFunction)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparerFunction(array[j], array[i]))
                    {
                        T temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }

            return array;
        }
        public static List<T> OrderBy<T>(List<T> list, Func<T, T, bool> comparerFunction)
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

        public static TResult[] Select<TSource, TResult>(TSource[] stringVehicles, Func<TSource, TResult> selector)
        {
            TResult[] vehicles = new TResult[stringVehicles.Length];
            for (int i = 0; i < stringVehicles.Length; i++)
            {
                vehicles[i] = selector(stringVehicles[i]);
            }

            return vehicles;
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
