using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onPositionEnemy : MonoBehaviour {

    public bool destroyCheck;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Lobenchi")
        {
            destroyCheck = true;
            Destroy(this.gameObject);
        }
    }

}
