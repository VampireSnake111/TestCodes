using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.InitializePlayer("Wasim", 50);
        player2.InitializePlayer("Mohammed", 100);

        player1.Heal(10);
        player1.Heal(true);

        Player.ShowPlayerCount();
    }
}
