using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment16{
    public struct Position
    {
        public float x, y, z;
        
        public Position(float x, float y, float z){
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void printPosition(){
            Debug.Log("X: "+x+"\nY: "+y+"\nZ: "+z);
        }
    }
}