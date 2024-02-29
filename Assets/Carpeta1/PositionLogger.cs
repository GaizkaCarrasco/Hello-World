using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLogger : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform transformation;
    void Start()
    {
        GameObject cube = GameObject.Find("Cube");
        transformation = cube.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        PositionDebug();
    }

    private void PositionDebug()
    {
        Debug.Log("Posicion:" + transformation.position);
        Debug.Log("Rotacion:" + transformation.rotation);
        Debug.Log("Escala:" + transformation.localScale);

    }
}
