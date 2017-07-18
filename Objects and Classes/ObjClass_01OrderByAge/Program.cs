﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjClass_01OrderByAge


{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>  command = Console.ReadLine().Split().ToList();
            List<dynamic> list = new List<dynamic>();
            
            while (command[0] != "End")
            {
                string name = command[0].ToString();
            string id = command[1].ToString();
            int age = int.Parse(command[2]);
            dynamic person = new { name, id, age };
                list.Add(person);
                command = Console.ReadLine().Split().ToList();
            }
            if (command[0] == "End")
            {
              
               var result = list.OrderBy(x => x.age);
                foreach (var item in result)
                {
             
                Console.WriteLine($"{item.name} with ID: {item.id} is {item.age} years old.");
               }
            }
        }
         
    }
}
