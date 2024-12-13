using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

namespace Assignment18{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer<string> gc = new GameContainer<string>();
            
            gc.SetItem("Health Potion");
            string name = gc.GetItem();
            Debug.Log("Stored Item: "+name);

            Debug.Log(GameUtils.DescribeItem(name));
        }
    }
}
