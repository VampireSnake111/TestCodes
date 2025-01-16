using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16{
    public class Officer : CharachterB
    {
        public Officer() : base(){}

        public Officer(string name, int health, Position position) : base(name, health, position){}

        public new void DisplayInfo(){
            Debug.Log("Officer");
            base.DisplayInfo();
        }
    }
}
