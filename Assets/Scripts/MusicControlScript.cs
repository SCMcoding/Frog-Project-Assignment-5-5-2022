using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BigScript : MonoBehaviour

{ 
public static BigScript BigInstance;

private void Awake()

{
    if (BigInstance != null && BigInstance != this)
    {
        Destroy(this.gameObject);
        return;

    }
    DontDestroyOnLoad(this);

}


}
