using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelloWorldCarpeta1
{
    public class HelloWorld : MonoBehaviour
    {
        Enemy enemy;
        Player player;
        // Start is called before the first frame update
        void Start()
        {
            player = new Player("Alonso");
            enemy = new Enemy("Rigoberto");
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log("Nombre: " + enemy.name + ". Vida" + enemy.getHealthPoint());
            Debug.Log("Soy Hello World de la carpeta 1");
        }
    }
}
