using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Pendulo : MonoBehaviour
{
    // Start is called before the first frame update\\

    [SerializeField]
    float angulo;

    [SerializeField]
    float anguloAcumulado;

    [SerializeField]
    bool cambiaSentido;

    [SerializeField]
    float tiempoTranscurrido;
    void Start()
    {

        cambiaSentido = false;
        angulo = -1;
        anguloAcumulado = 0;
        tiempoTranscurrido = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (tiempoTranscurrido >= 0.01)
        {
            transform.Rotate(new Vector3(angulo, 0, 0));
            anguloAcumulado += angulo;

            if (anguloAcumulado == -40)
            {
                angulo = 1;
            }
            else if (anguloAcumulado == 40)
            {
                angulo = -1;
            }
            tiempoTranscurrido = 0;
        }
        tiempoTranscurrido += Time.deltaTime;

    }
}
