using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForces : MonoBehaviour
{
    Rigidbody ourRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            ourRigidbody.AddExplosionForce(1000, transform.position, 20);
                //AddForce(200 * Vector3.left);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position += Vector3.down;
    }
}
