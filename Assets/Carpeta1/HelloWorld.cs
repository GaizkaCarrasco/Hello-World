using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelloWorldCarpeta1
{
    public class HelloWorld : MonoBehaviour
    {
        Enemy enemy;
        Player player;
        void Start()
        {
            enemy = new Enemy("Ronaldo");
            player = new Player("Messi");
            Debug.Log("Hello World");
            Debug.Log("Bye World");
        }


        void Update()
        {
            Debug.Log("Nombre: " + enemy.name + ". Vida: " + enemy.HealthPoints);
            Debug.Log("Nombre: " + player.name + ". Vida: " + player.HealthPoints);
            if (player.HealthPoints != 0)
            {
                player.takeDamage();
            }

            if (enemy.HealthPoints != 0)
            {
                enemy.takeDamage();
            }
            else
            {
                Debug.Log(enemy.name + " ha muerto.");
            }

        }
    }
}
