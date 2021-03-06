﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Chapter10
{
    public enum ClassA
    {
        two = 2,
        three = 3,
        four = 4,
        five = 5,
        six = 6,
        seven = 7,
        eight = 8,
        nine = 9

           
    }
    static class Test
    {
        public static string toGeneratedString<T>(this T test) where T : ClassA
        {
            
            Array array = Enum.GetValues(typeof(T));
            for(int count = 0; count < array.Length; count++)
            {
                T item = (T)array.GetValue(count);

                if (test.ToString() == item.ToString())
                {
                    return array.GetValue(count).ToString();
                }
            }
            return "";
        }


    

    }
   
}
