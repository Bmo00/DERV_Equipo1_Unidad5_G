using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_MovBarreras : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    List<Transform> puntos;

    [SerializeField]
    int index_punto_actual; // indice del punto destino actual
    void Start()
    {
        index_punto_actual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            puntos[index_punto_actual].position, 0.01f);


        if (Vector3.Distance(transform.position, puntos[index_punto_actual].position) <= 0.1)
        {
            index_punto_actual = ++index_punto_actual % puntos.Count;
        }
    }
}
