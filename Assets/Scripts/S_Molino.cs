using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Molino : MonoBehaviour
{

    [SerializeField]
    float angulo,tiempo_rotation;
    // Start is called before the first frame update
    void Start()
    {
        angulo = 0;
        tiempo_rotation = 0.01f;
        StartCoroutine("Molino_Movimiento");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator Molino_Movimiento()
    {
        while (true)
        {
            Quaternion destino = Quaternion.Euler(new Vector3(0, angulo, 0));
            transform.rotation = destino;

            angulo++;

            if (angulo == 360)

            {
                angulo = 1;
            }
            yield return new WaitForSeconds(tiempo_rotation);
        }
    }
}
