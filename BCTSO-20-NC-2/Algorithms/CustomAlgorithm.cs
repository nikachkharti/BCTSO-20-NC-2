﻿using Algorithms.Models;

namespace Algorithms
{
    public static class CustomAlgorithm
    {
        public static int FirstOrDefault(int[] collection, int value)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == value)
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static int FirstOrDefault(List<int> collection, int value)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == value)
                {
                    return collection[i];
                }
            }

            return default;
        }

        public static int LastOrDefault(int[] collection, int value)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (collection[i] == value)
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static int LastOrDefault(List<int> collection, int value)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] == value)
                {
                    return collection[i];
                }
            }

            return default;
        }

        public static int[] Where(int[] collection, int value)
        {
            List<int> result = new();

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == value)
                {
                    result.Add(collection[i]);
                }
            }

            return result.ToArray();
        }
        public static List<int> Where(List<int> collection, int value)
        {
            List<int> result = new();

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == value)
                {
                    result.Add(collection[i]);
                }
            }

            return result;
        }
        public static List<Vehicle> Where(List<Vehicle> collection, string make)
        {
            List<Vehicle> result = new();

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].Make.Trim().ToLower() == make.Trim().ToLower())
                {
                    result.Add(collection[i]);
                }
            }

            return result;
        }
        public static List<Vehicle> Where(Vehicle[] collection, string make)
        {
            List<Vehicle> result = new();

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i].Make.Trim().ToLower().Contains(make.Trim().ToLower()))
                {
                    result.Add(collection[i]);
                }
            }

            return result;
        }


        public static int IndexOf(int[] collection, int value)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int IndexOf(List<int> collection, int value)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == value)
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


        public static int Sum(int[] collection, int value)
        {
            int result = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                result += collection[i];
            }

            return result;
        }
        public static int Sum(List<int> collection, int value)
        {
            int result = 0;

            for (int i = 0; i < collection.Count; i++)
            {
                result += i;
            }

            return result;
        }

    }
}
