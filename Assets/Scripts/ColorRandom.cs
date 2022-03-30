using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandom : MonoBehaviour
{
    public SpriteRenderer GMod;

    void Start()
    {
        GMod = GetComponent<SpriteRenderer>();
    }







    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {

            GMod.color = Random.ColorHSV();
            print("changed");
        }
    }
}

