using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lectur15{
    public class EnumeratorsExamples : MonoBehaviour

    {
        void Start()
        {
            int character; // 0- Stopping / 1- Walking / 2- Running / 3- Jumping
            character = 1;

            if(character == 1){
                Debug.Log("Character is walking.");
            }

            CharacterState character2;

            character2 = CharacterState.Running;

            /*if(character2 == CharacterState.Running){
                Debug.Log("Character2 is running.");
            }*/

            switch(character2){

                case CharacterState.Stopping:
                Debug.Log("Charachter2 is stopping.");
                break;

                case CharacterState.Walking:
                Debug.Log("Charachter2 is walking.");
                break;

                case CharacterState.Running:
                Debug.Log("Charachter2 is running.");
                break;

                case CharacterState.Jumping:
                Debug.Log("Charachter2 is jumping.");
                break;

                default:
                Debug.Log("Any other state.");
                break;
            }
        }
    }
}

