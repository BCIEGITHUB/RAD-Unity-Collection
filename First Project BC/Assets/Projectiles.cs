using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    
    float projectilespeed = 10f;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += projectilespeed * transform.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.P))
        {
            Instantiate(projectile);
        }
    }
}
