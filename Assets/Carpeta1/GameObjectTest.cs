using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTest : MonoBehaviour
{
    // Start is called before the first frame update
    //private Transform transformation;
    void Start()
    {
        //transformation = this.GetComponent<Transform>();
    }
    
    // Update is called once per frame
    void Update()
    {
        PositionDebug();
    }

    private void PositionDebug()
    {
        Debug.Log("Posicion:" + this.transform.position);
        Debug.Log("Rotacion:" + this.transform.rotation);
        Debug.Log("Escala:" + this.transform.localScale);

    }
}
