using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMod : MonoBehaviour
{

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(8f, transform.position.y),
        1f * Time.deltaTime);

}
}
