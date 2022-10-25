using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour
{
    private float turningSpeed =180;
    public Transform PC;
    Rigidbody playerrigidbody;
    public GameObject projectile;
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
            playerrigidbody.AddForce(Vector3.up * 3000000, ForceMode.Force);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.P))
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }
        //Following code was inspired by:https://gamedev.stackexchange.com/questions/63746/unity-addexplosionforce-not-doing-anything
        if (Input.GetKey(KeyCode.F))
        {
            Force();
        }
        void Force()
        {
            Vector3 explosion = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosion, 25f);

            foreach(Collider hit in colliders)
            {
                if (!hit)
                {
                    continue;
                }

                if(hit.attachedRigidbody)
                {
                    hit.attachedRigidbody.AddExplosionForce(2000f, explosion, 20f);
                }
            }
        }
        //End of inspired Code
      
        

    }
}
