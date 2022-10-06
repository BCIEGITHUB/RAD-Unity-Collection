using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{

    int CHP = 100;
    public int MHP = 100;
    // Start is called before the first frame update
    void Start()
    {
        CHP = MHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h"))
            takeDamage(12);
    }

    internal void takeDamage(int damage)
    {
        CHP -= damage;
        print("aUGH, I only have " + CHP + " Health left");
    }

    internal int whatsyourMaxHealth()
    {
        return MHP;
    }
}
