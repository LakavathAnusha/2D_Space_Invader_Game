using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLaunch : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public GameObject bulletPrefab;
    public Vector3 offset;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, player.position + offset, player.rotation);
        }
    }
}
