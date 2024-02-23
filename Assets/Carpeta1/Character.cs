using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string name;
    private int healthPoint { get; set; } = 10;

   public Character(string s)
    {
        this.name = s;
        Debug.Log("Hola soy" + name + "y tengo " + healthPoint + "puntos de vida");
    }

    ~Character()
    {
        Debug.Log("Destroyed");
    }

    //public int getHealthPoint()
    //{
    //    return healthPoint;
    //}

    public void TakeDamage()
    {
        this.healthPoint -= 1;
    }
}
