using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsParabola : MonoBehaviour {

    public float velocidad;
    public Transform target;
	// Use this for initialization
	void Start () {
        velocidad = 2.0f;
	}

     Vector2 CalcularSaeta()
    {
        //definir primero el tercer punto
        Vector2 tercerPunto = new Vector2 (0.0f, 0.0f);

        //Emplear los dos puntos conocidos para calcular el tercero apuntando hacia abajo siempre
        //-----------------------------------------------------------------------------------------

        //Obtener punto inicial
        Vector2 ptA = new Vector2(0.0f,0.0f);
        ptA = this.transform.position;
        Debug.Log("Punto a en: "); Debug.Log(ptA);

        //Obtener punto final
        Vector2 ptB = new Vector2(0.0f, 0.0f);
        ptB = target.position;
        Debug.Log("Punto b en: "); Debug.Log(ptB);

        //calcular vector director
        Vector2 dirigido = new Vector2(0.0f,0.0f);
        dirigido = ptB - ptA;
        Debug.Log("Vector Director: "); Debug.Log(dirigido);

        //Calcular tercer punto
        //-----------------------------------------------------------------------------------------

        //calcular punto medio de la recta
        Vector2 puntoMedio = new Vector2( (ptA.x + ptB.x)/2 , (ptA.y + ptB.y)/2 );
        Debug.Log("Punto Medio en: "); Debug.Log(puntoMedio);

        //Calcular pendiente de recta normal.
        float m = 1;
        if (dirigido.y != 0)
        {
            m = -dirigido.x / dirigido.y;
        }else m = Mathf.Infinity;

        //calcular vector director de la recta normal por el punto medio
        Vector2 dirNormal = new Vector2(-puntoMedio.x, -m*puntoMedio.x);
        Debug.Log("Vector Normal es: "); Debug.Log(dirNormal);

        //elegir punto sobre el vector normal
        tercerPunto = dirNormal * -0.7f;
        Debug.Log("Tercer Punto es: "); Debug.Log(tercerPunto);

        //Devolver el tercer punto
        return tercerPunto; 
    }

    void CalcularParabola()
    {
        //formar una matriz con los valores de los tres puntos
        //Resolver el sistema matricial
        //Devolver los parámetros de la parábola construída.
    }

	// Update is called once per frame
	void FixedUpdate () {
        //transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        CalcularSaeta();
    }
}
