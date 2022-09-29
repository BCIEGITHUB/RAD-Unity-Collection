using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    private float turningSpeed =180;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += transform.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow))
           transform.position -= transform.forward * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += Vector3.left * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += Vector3.right * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
            transform.position += Vector3.up * Time.deltaTime;
        if (Input.GetKey(KeyCode.C))
            transform.position -= Vector3.up * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.left, turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left, -turningSpeed * Time.deltaTime);
        }

    }
}
