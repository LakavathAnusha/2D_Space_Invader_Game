using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed;

    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
