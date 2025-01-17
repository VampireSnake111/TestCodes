using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment24
{
    public class RacingGame : MonoBehaviour
    {
        public RaceState raceState;
        public void SimulateRace(){
            switch(raceState){

                case RaceState.Start:
                Debug.Log("Ready, Set, Go!");
                break;

                case RaceState.Accelerate:
                Debug.Log("Faster, faster!");
                break;
                
                case RaceState.Turn:
                Debug.Log("Sharp turn!");
                break;
                
                case RaceState.Crash:
                Debug.Log("CRAAAASH!!");
                break;
                
                case RaceState.Finish:
                Debug.Log("Player 1 crossed the finish line!!!");
                break;

                default:
                Debug.Log("Waiting for race to start.");
                break;
            }
        }

        void Update()
        {
            SimulateRace();
        }
    }
}

