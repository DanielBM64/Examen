using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goombaC : MonoBehaviour
{
    public float Goomba;
    public Rigidbody2D rigidBodyGoomba;
    public float movimientoHorizontal;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal");
        rigidBodyGoomba.velocity = new Vector2(movimientoHorizontal, 0) * velocidad;
    }
}
