using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkasteroids : MonoBehaviour
{
    
    public GameObject Asteroid0;
    

    public bool Asteroid0_is_destroyed;
    

    void Update()
    {
        if (Asteroid0 == null)
        {
            Asteroid0_is_destroyed = true;
        }





    }
}
