using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture16
{
    public class CameraFollow : MonoBehaviour
    {
        public GameObject targetObject;
        void Start()
        {
            
        }

        void Update()
        {
            transform.position = targetObject.transform.position;
        }
    }
}

