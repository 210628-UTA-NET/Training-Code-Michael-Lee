using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Collection
    {
        static List<string> strings = new List<string>();
        
        public static void CollectionMain()
        {
            Console.WriteLine("====Collection Demo====");
            Console.WriteLine("=List Demo=");
            //adding string elements to our strings list
            strings.Add("First Element");
            strings.Add("Second Element");
            strings.Add("Third Element");
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < strings.Count; i++)
            {
                Console.Write("Current index is " + i);
                Console.WriteLine(strings[i]);
            }
            int x = 0;
            while (x < strings.Count)
            {
                Console.WriteLine(strings[x]);
                x++;
            }
            Console.WriteLine("=ArrayList Demo=");
             
        }
    }
}