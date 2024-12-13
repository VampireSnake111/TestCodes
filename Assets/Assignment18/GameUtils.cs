using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
    public class GameUtils
    {
        public static string DescribeItem<T>(T value){
            string desc = "This item is a "+value;
            return desc;
        }
    }
}
