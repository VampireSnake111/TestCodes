using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory potions = new Inventory();
        Inventory elixirs = new Inventory();

        potions.AddItem("Healing Potion");
        potions.AddItem("Strength Potion");
        elixirs.AddItem("Elixir");
        elixirs.AddItem("Dark Elixir");

        Inventory newInventory = potions + elixirs;
        newInventory.ShowItems();
    }
}
