
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMod : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(15f, transform.position.y),
        1f * Time.deltaTime);

    }
}
