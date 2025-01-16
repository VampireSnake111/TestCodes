using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Charachter
{
    public Enemy(string Name, int Health) : base(Name, Health)
    {
    }

    public void Attack(PlayerA player, int amount){
        player.setHealth(player.getHealth() - amount);
    }
}
