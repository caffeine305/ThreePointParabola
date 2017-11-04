using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour {

    public GameObject enemy;

    void Start()
    {
        StartCoroutine(InstantiateTarget());
    }

    IEnumerator InstantiateTarget()
    {
        SetRandomPosition();

        yield return new WaitUntil(() => CompareEnemyAndTag());

        if (CompareEnemyAndTag())
            Destroy(this.gameObject);
    }

    void SetRandomPosition()
    {
        float x = Random.Range(-7.0f, 7.0f);
        float y = 3.4f;
        transform.position = new Vector2(x, y);
    }

    bool CompareEnemyAndTag()
    {
        Vector2 eval = new Vector2(1.0f, 1.0f);
        eval = transform.position - enemy.transform.position;

        if (eval.sqrMagnitude == 0)
            return true;
        else
            return false;
    }

}
