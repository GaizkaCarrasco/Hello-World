using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string name;
    private int healthPoint = 1;

   public Character(string s)
    {
        this.name = s;
        Debug.Log("Hola soy" + name + "y tengo " + healthPoint + "puntos de vida");
    }

    ~Character()
    {
        Debug.Log("Destroyed");
    }

    public int getHealthPoint()
    {
        return healthPoint;
    }
}
