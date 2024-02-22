using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    Enemy enemy;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = new Player("Alfredo");
        enemy = new Enemy("Roberto");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Nombre: " + enemy.name + ". Vida" + enemy.getHealthPoint());
    }
}
