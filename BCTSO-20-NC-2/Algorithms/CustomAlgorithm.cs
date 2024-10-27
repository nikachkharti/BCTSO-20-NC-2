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

        /*



public static int IndexOf(int[] collection, ComparerDelegateForInts comparerFunction)
{
for (int i = 0; i < collection.Length; i++)
{
 if (comparerFunction(collection[i]))
 {
     return i;
 }
}

return -1;
}
public static int IndexOf<T>(T[] collection, T value)
{
for (int i = 0; i < collection.Length; i++)
{
 if (collection[i].Equals(value))
 {
     return i;
 }
}

return -1;
}
public static int IndexOf<T>(List<T> collection, T value)
{
for (int i = 0; i < collection.Count; i++)
{
 if (collection[i].Equals(value))
 {
     return i;
 }
}

return -1;
}
public static int IndexOf(List<int> collection, ComparerDelegateForInts comparerFunction)
{
for (int i = 0; i < collection.Count; i++)
{
 if (comparerFunction(collection[i]))
 {
     return i;
 }
}

return -1;
}


public static int LastIndexOf(int[] collection, int value)
{
for (int i = collection.Length - 1; i >= 0; i--)
{
 if (collection[i] == value)
 {
     return i;
 }
}

return -1;
}
public static int LastIndexOf(List<int> collection, int value)
{
for (int i = collection.Count - 1; i >= 0; i--)
{
 if (collection[i] == value)
 {
     return i;
 }
}

return -1;
}
public static int LastIndexOf(int[] collection, ComparerDelegateForInts compareFunction)
{
for (int i = collection.Length - 1; i >= 0; i--)
{
 if (compareFunction(collection[i]))
 {
     return i;
 }
}

return -1;
}
public static int LastIndexOf(List<int> collection, ComparerDelegateForInts compareFunction)
{
for (int i = collection.Count - 1; i >= 0; i--)
{
 if (compareFunction(collection[i]))
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


public static Vehicle[] Take(Vehicle[] vehicles, int count)
{
Vehicle[] economicCars = new Vehicle[count];
for (int i = 0; i < economicCars.Length; i++)
{
 economicCars[i] = vehicles[i];
}

return economicCars;
}






public static int Max(List<int> intList)
{
int max = intList[0];

for (int i = 0; i < intList.Count; i++)
{
 if (intList[i] > max)
 {
     max = intList[i];
 }
}

return max;
}
public static int Max(int[] intAr)
{
int max = intAr[0];

for (int i = 0; i < intAr.Length; i++)
{
 if (intAr[i] > max)
 {
     max = intAr[i];
 }
}

return max;
}
public static int Min(List<int> intList)
{
int min = intList[0];

for (int i = 0; i < intList.Count; i++)
{
 if (intList[i] < min)
 {
     min = intList[i];
 }
}

return min;
}
public static int Min(int[] intAr)
{
int min = intAr[0];

for (int i = 0; i < intAr.Length; i++)
{
 if (intAr[i] < min)
 {
     min = intAr[i];
 }
}

return min;
}


public static bool Any(int[] intAr, ComparerDelegateForInts comparerFunctions)
{
for (int i = 0; i < intAr.Length; i++)
{
 if (comparerFunctions(intAr[i]))
 {
     return true;
 }
}

return false;
}
public static bool Any(List<int> intList, ComparerDelegateForInts comparerFunctions)
{
for (int i = 0; i < intList.Count; i++)
{
 if (comparerFunctions(intList[i]))
 {
     return true;
 }
}

return false;
}
public static bool Any(List<int> intList, int element)
{
for (int i = 0; i < intList.Count; i++)
{
 if (intList[i] == element)
 {
     return true;
 }
}

return false;
}


public static bool All(int[] intAr, int element)
{
for (int i = 0; i < intAr.Length; i++)
{
 if (intAr[i] != element)
 {
     return false;
 }
}

return true;
}
public static bool All(List<int> intList, int element)
{
for (int i = 0; i < intList.Count; i++)
{
 if (intList[i] != element)
 {
     return false;
 }
}

return true;
}
public static bool All(List<int> intList, ComparerDelegateForInts comparerFunction)
{
for (int i = 0; i < intList.Count; i++)
{
 if (!comparerFunction(intList[i]))
 {
     return false;
 }
}

return true;
}
public static bool All(int[] intAr, ComparerDelegateForInts comparerFunction)
{
for (int i = 0; i < intAr.Length; i++)
{
 if (!comparerFunction(intAr[i]))
 {
     return false;
 }
}

return true;
}


public static int[] Reverse(int[] collection)
{
Stack<int> stack = new();

for (int i = 0; i < collection.Length; i++)
{
 stack.Push(collection[i]);
}

return stack.ToArray();
}
public static List<int> Reverse(List<int> collection)
{
Stack<int> stack = new();

for (int i = 0; i < collection.Count; i++)
{
 stack.Push(collection[i]);
}

return stack.ToList();
}


*/


        //TODO Union
        //TODO Intersect

    }
}
