using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class vida_FPC : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("arma"))
        {
            print("Daño");
        }
    }
    public int vidaPlayer;
    public Slider vidaVisual;
    void Start()
    {
        vidaPlayer = 100;
    }
    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;
        if(vidaPlayer <= 0 )
        {
            Debug.Log("GAME OVER");
        }
    }
}
