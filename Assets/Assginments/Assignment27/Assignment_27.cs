using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Assignment_27 : MonoBehaviour
{
    void Start()
    {
        int a = 0;
        int b = 20;

        addTen(a);
        Debug.Log(a);

        addTen(ref b);
        Debug.Log(b);

        newValue(out a);
        Debug.Log(a);
    }

    public void addTen(int x){
        x = x + 10;
    }

    public void addTen(ref int x){
        x = x + 10;
    }

    public void newValue(out int x){
        x = 15;
    }
}
