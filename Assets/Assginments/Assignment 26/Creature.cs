using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment26{
    public class Creature
    {
        public virtual void Speak(){
            Debug.Log("A creature makes a sound.");
        }
    }
    public interface IRunnable{
        void Run(){

        }
    }
    public interface IJumpable{
        void Jump(){

        }
    }
    public interface ISwimmable{
        void Swim(){

        }
    }

    public class Kangaroo : Creature, IRunnable, IJumpable{
        public void Run(){
            Debug.Log("Kangaroo runs.");
        } 
        public void Jump(){
            Debug.Log("Kangaroo jumps.");
        }
        public override void Speak(){
            Debug.Log("Kangaroo says: Hop!");
        } 
    }
    
    public class Duck : Creature, IRunnable, ISwimmable
    {
        public void Swim()
        {
            Debug.Log("Duck swims.");
        }

        public void Run()
        {
            Debug.Log("Duck runs.");
        }
        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }
    }
}