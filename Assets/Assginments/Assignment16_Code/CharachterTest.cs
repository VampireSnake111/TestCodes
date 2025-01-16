using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment16{

    public class CharachterTest : MonoBehaviour
    {
        void Start(){
            CharachterB[] charachters = new CharachterB[2];
            charachters[0] = new Soldier();
            charachters[1] = new Officer("Captain", 80, new Position(10, 5, 0));

            foreach (CharachterB charachter in charachters){
                charachter.DisplayInfo();
            }

            Debug.Log("Soldier health: "+charachters[0].Health);
            charachters[1].Attack(10, charachters[0]);
            Debug.Log("Soldier health: "+charachters[0].Health);
        }
    }
}
