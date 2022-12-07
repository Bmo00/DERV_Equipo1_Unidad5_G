using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class QuitarVIda : MonoBehaviour
{
    public int vidaPlayer;

    public int intentos;

    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject spawn;

    [SerializeField]
    TextMeshProUGUI txt_intentos;

    [SerializeField]
    Slider vida;

    String actual;

    void Start()
    {
        vidaPlayer = 100;
        vida.GetComponent<Slider>().value = vidaPlayer;
    }

    private void OnCollisionEnter(Collision collision)
    {
        string tag;
        tag = collision.gameObject.tag;


        if (tag.Equals("Obstaculo"))
        {
            vidaPlayer -= 10;
            vida.GetComponent<Slider>().value = vidaPlayer;
        }
        if (vidaPlayer <= 0)
        {
            vida.GetComponent<Slider>().value = vidaPlayer;
            if (vida.GetComponent<Slider>().value < 100)
            {
                vidaPlayer = 100;
                vida.GetComponent<Slider>().value = vidaPlayer;
            }
            player.transform.position = spawn.transform.position;
            actual = txt_intentos.text.ToString();
            intentos = int.Parse(actual);
            intentos++;
            txt_intentos.text = intentos.ToString();


        }




    }
}
