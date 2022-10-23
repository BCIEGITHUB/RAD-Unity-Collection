using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    private float turningSpeed =180;
    public Transform PC;
    Rigidbody playerrigidbody;
    //public Transform cubeTemplate;

    // Start is called before the first frame update
    void Start()
    {
        playerrigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += transform.forward * 4 * Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow))
           transform.position -= transform.forward * 2 * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position -= transform.right * 3 * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += transform.right * 3 * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
            transform.position += transform.up * Time.deltaTime;
        if (Input.GetKey(KeyCode.C))
            transform.position -= transform.up * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }
      
        

    }
}
