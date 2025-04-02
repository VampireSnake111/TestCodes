using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Lecture16
{
    public class ColorExample : MonoBehaviour
    {
        public Color startColor = Color.red; // RGB - HSV
        public Color endColor = Color.blue;
        //int counter = 0;
        Renderer renderer;
        Material material;
        float timer = 0;
        int turn = 0;
        void Start()
        {

        }
        
        void Update()
        {   
            //counter++;
            renderer = GetComponent<Renderer>();
            //GetComponent<Rigidbody>();
            material = renderer.material;
            //material.color = color2;

            /*if(counter % 500 == 0){
                material.color = new Color(Random.value, Random.value, Random.value);
                counter = 0;
            }*/
            
            if(turn == 0){
                timer += Time.deltaTime;
                material.color = Color.Lerp(startColor, endColor, timer/0.5f);
                
                if(material.color == endColor){
                    timer = 0;
                    turn = 1;
                }
            }
            
            else{
                timer += Time.deltaTime;
                material.color = Color.Lerp(endColor, startColor, timer/0.5f);
                
                if(material.color == startColor){
                    timer = 0;
                    turn = 0;
                }
            }
        }
    }
}

