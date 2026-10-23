using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float topHeigh;// lmite de las palas
    public float botHeigh;
    public bool useArrowKeys = false;// if true, use arrow key; if false, use W S

    void Update()
    {
        MovePaddle();
    }
    void MovePaddle()
    {
        this.gameObject.transform.position = new Vector3(this.transform.position.x, ConstrainPaddle(), this.transform.position.z);
    }
    float ConstrainPaddle()
    {
        float nuevaY = this.gameObject.transform.position.y + (PaddleDirection() * moveSpeed * Time.deltaTime);
        if (nuevaY > topHeigh)
        {
            nuevaY = topHeigh;
        }
        if (nuevaY < botHeigh)
        {
            nuevaY = botHeigh;
        }
        return nuevaY;
    }
        //nuevaY = Math,Clamp(nuevaY, limiteAbajo, limiteArriba);
    
    float PaddleDirection()
    {
        float direccion = 0f;
        if (useArrowKeys == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                direccion = 1f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                direccion = -1f;
            }

        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                direccion = 1f;

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                direccion = -1f;
            }

        }
        return direccion;
    }
}