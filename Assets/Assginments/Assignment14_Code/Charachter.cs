using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Charachter : MonoBehaviour
{
        private string Name;
        private int Health;

        public Charachter(string Name, int Health){
            this.Name = Name;
            this.Health = Health;
        }

        public string getName(){
            return Name;
        }

        public void setName(string name){
            this.Name = name;
        }

        public int getHealth(){
            return Health;
        }

        public void setHealth(int health){
            this.Health = health;
        }
}
