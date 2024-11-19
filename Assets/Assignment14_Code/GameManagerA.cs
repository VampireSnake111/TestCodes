using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerA : MonoBehaviour
{
    void Start()
    {
        PlayerA player = new PlayerA("VampireSnake111", 90);
        Enemy enemy = new Enemy("Dark Knight", 100);

        Debug.Log("Player Name: "+player.getName()+"\nPlayer Health: "+player.getHealth()+"\n");
        Debug.Log("Enemy Name: "+enemy.getName()+"\n Enemy Health: "+enemy.getHealth());

        player.Heal(10);
        Debug.Log("Player Health: "+player.getHealth());

        enemy.Attack(player, 10);
        Debug.Log("Player Health: "+player.getHealth());
    }
}
