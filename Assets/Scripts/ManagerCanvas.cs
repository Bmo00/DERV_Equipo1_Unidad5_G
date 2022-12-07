using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ManagerCanvas : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI t_tiempo;

    int tiempoInicio;
    private void Awake()
    {
        GameObject obj = GameObject.Find("txt_Tiempo");
        t_tiempo = obj.GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        tiempoInicio = 0;
        StopAllCoroutines();
        StartCoroutine("controlTiempo");
    }

    IEnumerator controlTiempo()
    {
        while (tiempoInicio >= -1)
        {
            t_tiempo.text = tiempoInicio.ToString();
            tiempoInicio++;
            yield return new WaitForSeconds(1f);
        }
    }
}
