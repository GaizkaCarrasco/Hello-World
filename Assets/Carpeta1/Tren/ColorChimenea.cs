using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChimenea : MonoBehaviour
{
    public Color color;
    public bool finByTag;
    public string chosenTag;
    private GameObject[] gameObjects;

    // Start is called before the first frame update
    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Chimenea");
    }

    // Update is called once per frame
    void Update()
    {
        ColorObjects();
    }

    private void ColorObjects()
    {

        if (finByTag)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = color;
            }
        }
    }
}
