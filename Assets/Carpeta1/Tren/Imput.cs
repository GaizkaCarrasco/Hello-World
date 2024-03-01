using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imput : MonoBehaviour
{
    private GameObject[] allGameObjects;
    // Start is called before the first frame update
    void Start()
    {
        allGameObjects = GameObject.FindGameObjectsWithTag("Wheel");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Espacio pulsado");
            
        }
    }


}
