using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemyTargetPair : MonoBehaviour {

    public GameObject enemy;
    public GameObject target;
    GameObject targetInstance;

    Vector2 setPos;

    void Awake()
    {
        targetInstance = Instantiate(target, transform.position, transform.rotation);
        StartCoroutine(InstantiateEnemy());
    }

    void SetRandomPosition()
    {
        float x = Random.Range(-10.0f, 10.0f);
        float y = 3.5f;
        setPos = new Vector2(x, y);
        //transform.position = setPos;
    }

    IEnumerator InstantiateEnemy()
    {
        while (true)
        {
            Vector2 setEnemyPos = new Vector2(-7.0f, -3.0f);
            Instantiate(enemy, setEnemyPos, transform.rotation);

            SetRandomPosition();
            Instantiate(targetInstance, setPos, transform.rotation); ///Persiste el error, los enemigos se van al Transform del Prefab. Quizá hay que cargar por listas.

            yield return new WaitForSeconds(3.0f); //se puede ir acelerando el ritmo del Instantiate con una variable
        }
    }

}
