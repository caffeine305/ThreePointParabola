using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {


    public float velocidad;
    public Transform target;
    public int enemyType;
    float initialPosY;
    float fixTargetPosX;
    int checkErrorX;
    Vector2 actualTarget;

    //Clave enemigo:
    //terrestre = 0, aereo = 1


    void Start () {
        velocidad = 2.0f;
        initialPosY = transform.position.y;
        fixTargetPosX = target.position.x;
        checkErrorX = (int)transform.position.x - (int)target.position.x;
        actualTarget = target.position;
        Debug.Log(actualTarget);
    }

    void moveAerial()
    {
        float step = velocidad * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, actualTarget, step);
    }

    void moveTerra()
    {
        float step = velocidad * Time.deltaTime;
        Vector2 moveFloor = new Vector2(fixTargetPosX,initialPosY);
        Debug.Log("Punto Auxiliar" + moveFloor);
       
        transform.position = Vector2.MoveTowards(transform.position, moveFloor, step);
        checkErrorX = (int)transform.position.x - (int)target.position.x;
        Debug.Log("Error: " + checkErrorX);        
    }

    void FixedUpdate()
    {

        if (enemyType == 0)
        {
            if (checkErrorX != 0)
                moveTerra();

            if (checkErrorX == 0)
                moveAerial();
        
        }else
            moveAerial();
    }
}
