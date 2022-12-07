using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vida_enemigo_1 : MonoBehaviour
{
    public int vidaEnemigo;
    public Slider vidaEVisual;
    // Start is called before the first frame update
    void Start()
    {
        vidaEnemigo = 100;
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("bate"))
        {
            print("Daño");
        }
    }

    // Update is called once per frame
    void Update()
    {
        vidaEVisual.GetComponent<Slider>().value = vidaEnemigo;
        if (vidaEnemigo <= 0)
        {
            Debug.Log("ZOMBIE DERRIBADO");
            Destroy(gameObject);
        }
    }
}
