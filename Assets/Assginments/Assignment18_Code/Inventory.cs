using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Assignment18{
    public class Inventory
    {
        private List<string> List1 = new List<string>();

        public void AddItem(string item){
            List1.Add(item);
        }

        public void ShowItems(){
            foreach (string item in List1){
                Debug.Log(item);
            }
        }

        public static Inventory operator +(Inventory inv1, Inventory inv2){
            Inventory inv = new Inventory();
            inv.List1.AddRange(inv1.List1);
            inv.List1.AddRange(inv2.List1);
            return inv;
        }
    }
}
