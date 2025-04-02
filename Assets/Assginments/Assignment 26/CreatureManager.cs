using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26{
    public class CreatureManager : MonoBehaviour
    {
        Kangaroo kangaroo;
        Duck duck;
        void Start()
        {
            List<Creature> Creatures = new List<Creature>() { kangaroo, duck };
            List<IRunnable> Runnable = new List<IRunnable>() { kangaroo, duck };
            List<IJumpable> Jumpable = new List<IJumpable>() { kangaroo };
            List<ISwimmable> Swimmable = new List<ISwimmable>() { duck };

            foreach (Creature creature in Creatures) creature.Speak();
            foreach (IRunnable creature in Runnable) creature.Run();
            foreach (IJumpable creature in Jumpable) creature.Jump();
            foreach (ISwimmable creature in Swimmable) creature.Swim();
        }
    }
}

