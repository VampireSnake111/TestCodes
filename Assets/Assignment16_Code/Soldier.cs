using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16{
    public class Soldier : CharachterB
    {
        public Soldier() : base(){}

        public Soldier(string name, int health, Position position) : base(name, health, position){}

        public new void DisplayInfo(){
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }
}
