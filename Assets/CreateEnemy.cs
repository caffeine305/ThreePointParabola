using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour {

    public GameObject enemy;
    public GameObject target;

    void Start()
    {
        StartCoroutine(InstantiateEnemy());
    }

    IEnumerator InstantiateEnemy()
    {
        while (true)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            Instantiate(target, transform.position, transform.rotation);
            yield return new WaitForSeconds(3.0f); //se puede ir acelerando el ritmo del Instantiate con una variable
        }
    }

}
