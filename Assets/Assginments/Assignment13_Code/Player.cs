using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    string playerName;
    int health;
    static int playerCount;

    public void InitializePlayer(string name, int initialHealth){
        this.playerName = name;
        this.health = initialHealth;
        playerCount += 1;
    }

    public void Heal(int amount){
        health += amount;
        Debug.Log(playerName+" Health: "+health);
    }

    public void Heal(bool fullRestore){
        if(fullRestore == true){
            health = 100;
            Debug.Log(playerName+" health fully restored!");
        }
    }

    public static void ShowPlayerCount(){
        Debug.Log("Players currently online: "+playerCount);
    }
}
