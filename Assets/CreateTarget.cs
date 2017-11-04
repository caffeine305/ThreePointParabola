using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTarget : MonoBehaviour {

    public GameObject target;
    //GameObject instance;
    bool destroyCheck;

    void Start()
    {
        StartCoroutine(InstantiateWithDelay());
    }

    IEnumerator InstantiateWithDelay()
    {
        while (true)
        {
            Instantiate(target, transform.position, transform.rotation);
            yield return new WaitForSeconds(20.0f);
        }
    }


}
