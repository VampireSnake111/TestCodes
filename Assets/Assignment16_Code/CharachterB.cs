using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16{
    public class CharachterB
    {
        public string name;
        private int health;
        protected Position position;

        public CharachterB() : this("No name", 100, new Position(0,0,0)){}

        public CharachterB (string name, int health, Position position){
            this.name = name;
            this.health = health;
            this.position = position;
        }

        public int Health{
            get {return health;}
            set {health = Mathf.Clamp(value, 0, 100);}
        }

        public void Attack(int damage, CharachterB target){
            target.health -= damage;
        }

        public void Attack(int damage, CharachterB target, string attackType){
            Attack(damage, target);
            Debug.Log(attackType);
        }

        public void DisplayInfo(){
            Debug.Log("Name: "+name+"\nHealth: "+health+"\nPosition: "+position);
        }
    }
}