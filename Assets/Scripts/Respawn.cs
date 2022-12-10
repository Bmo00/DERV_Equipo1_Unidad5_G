using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    int vidaplayer;
    public int intentos;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject spawn;
    [SerializeField]
    TextMeshProUGUI txt_intentos;
    [SerializeField]
    Slider vida;

    void Start()
    {
        txt_intentos.text = intentos.ToString();
        vidaplayer = 100;
        vida.GetComponent<Slider>().value = vidaplayer;
        intentos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < 1)
        {
            respawn();
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        string tag;
        tag = collision.gameObject.tag;

        if (tag.Equals("Obstaculo"))
        {
            vidaplayer -= 10;
            vida.GetComponent<Slider>().value = vidaplayer;
        }
        if (vidaplayer <= 0)
        {
            respawn();
        }
    }

    public void respawn()
    {
        vida.GetComponent<Slider>().value = vidaplayer;
        if (vida.GetComponent<Slider>().value < 100)
        {
            vidaplayer = 100;
            vida.GetComponent<Slider>().value = vidaplayer;
        }
        player.transform.position = spawn.transform.position;
        intentos++;
        txt_intentos.text = intentos.ToString();
    }
}
