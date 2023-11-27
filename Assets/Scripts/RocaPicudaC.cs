using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocaPicudaC : MonoBehaviour
{
    public GameObject rocapicuda;
    public Rigidbody2D rocapicudaRB;
    public GameObject suelo;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.CompareTag("Suelo"))
        //{
            //rocapicudaRB.AddForce(5, 0);
            //rocapicuda.transform.position(6, 1);
        //}
    }
}