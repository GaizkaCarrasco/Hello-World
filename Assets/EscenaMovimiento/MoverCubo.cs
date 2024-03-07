using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCubo : MonoBehaviour
{
    public int velocityX = 10;
    public int velocityY = 10;
    public int velocityZ = 10;
    public int scaleX = 1;
    public int scaleY = 1;
    public int scaleZ = 1;
    public int rotationX = 0;
    public int rotationY = 1;
    public int rotationZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PositionDebug();
        }
        checkMovement();
        //checkScale();
        checkRotate();
    }

    private void PositionDebug()
    {
        Debug.Log("Posicion en x:" + this.transform.position.x);
        Debug.Log("Posicion en y:" + this.transform.position.y);
        Debug.Log("Posicion en z:" + this.transform.position.z);
    }

    private void checkMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y , this.transform.localPosition.z + velocityZ * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z - velocityZ * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x + velocityX * Time.deltaTime, this.transform.localPosition.y, this.transform.localPosition.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x - velocityX * Time.deltaTime, this.transform.localPosition.y, this.transform.localPosition.z);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y + velocityY * Time.deltaTime, this.transform.localPosition.z);
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y - velocityY * Time.deltaTime, this.transform.localPosition.z);
        }
    }

    private void checkScale()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x + scaleX, this.transform.localScale.y, this.transform.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x - scaleX, this.transform.localScale.y, this.transform.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x , this.transform.localScale.y + scaleY, this.transform.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x , this.transform.localScale.y - scaleY, this.transform.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x , this.transform.localScale.y, this.transform.localScale.z + scaleZ);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z - scaleZ);
        }
    }

    private void checkRotate()
    {
        this.transform.rotation *= Quaternion.Euler(rotationX,rotationY,rotationZ);
        //transform.Rotate(New Vector3(0,180,0)); 180, 90, etc. Si no, hace cosas raras.
    }
}
