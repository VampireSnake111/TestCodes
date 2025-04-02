using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lectur15
{
    public class MoveCube : MonoBehaviour
    {
        float speed = 10f;
        void Start()
        {
            Camera.main.backgroundColor = Color.red;
        }

        void Update()
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10;
            Vector3 InUnityPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            if(Input.GetMouseButton(0)){
                //transform.position = InUnityPosition;
                transform.position = Vector3.Lerp(transform.position, InUnityPosition, speed * Time.deltaTime);
            }

            //Debug.Log(mousePosition);
        }
    }

}
