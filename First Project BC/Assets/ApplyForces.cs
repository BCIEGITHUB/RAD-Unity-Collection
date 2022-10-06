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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ourRigidbody.AddExplosionForce(1000, transform.position, 20);
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ourRigidbody.AddForce(200 * Vector3.right);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Help ObjectHitHealth = collision.gameObject.GetComponent<Help>();
        if (ObjectHitHealth)
        {
            print("Found Health Script in object hit");
            ObjectHitHealth.takeDamage(3);

            int ObjectMaxHealth = ObjectHitHealth.whatsyourMaxHealth();
            if (ObjectMaxHealth > 100)
                ObjectHitHealth.takeDamage(100);
        }
        else
        {
            print(" Did not find Health Script in object hit");
        }
    }
}
