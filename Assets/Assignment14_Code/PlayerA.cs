using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : Charachter
{
    public PlayerA(string Name, int Health) : base(Name, Health)
    {
    }

    public void Heal(int amount){
        setHealth(getHealth()+amount);
    }
}
