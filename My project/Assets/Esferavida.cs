using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esferavida : MonoBehaviour
{
    private bool destroyed;

 

    void Update()
    {
        if (this.gameObject != null)
        {
            if (!destroyed)
            {
                destroyed = true;
                Destroy(this.gameObject, 4f);
            }
        }


 

        
    }

}
