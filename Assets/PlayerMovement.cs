using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
  
    public float speed;
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float i = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * speed * i * Time.deltaTime);
        transform.Translate(Vector3.right * speed * h * Time.deltaTime);
        if(transform.position.x>7f)
        {
            transform.position = new Vector3(7f, transform.position.y, 0);
        }
        else if(transform.position.x<-7f)
        {
            transform.position = new Vector3(-7f, transform.position.y, 0);
        }
        if (transform.position.x > 4f)
        {
            transform.position = new Vector3(4f, transform.position.y, 0);
        }
        else if (transform.position.x < -4f)
        {
            transform.position = new Vector3(-4f, transform.position.y, 0);
        }


    }
}
