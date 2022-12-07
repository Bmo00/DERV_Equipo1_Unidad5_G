using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{

    public bool tengoArma;


    public float velocidadMovimiento = 5.2f;
    public float velocidadRotacion = 200.0f;
    private Animator anim;
    public float x, y;


    public Rigidbody rb;
    public bool estoyAtacando;
    public bool avanzoSolo;
    public float impulsoDeGolpe = 10f;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }


    void FixedUpdate()
    {
        if (!estoyAtacando)
        {
            transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
        }
        if (avanzoSolo)
        {
            rb.velocity = transform.forward * impulsoDeGolpe;
        }

    }
    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Return) && !estoyAtacando)
        {
            if (tengoArma)
            {
                anim.SetTrigger("Golpeo");
                estoyAtacando = true;
            }
        }






        if (!estoyAtacando)
        {
            anim.SetFloat("VelX", x);
            anim.SetFloat("VelY", y);
        }

    }

    public void DejoDeGolpear()
    {
        estoyAtacando = false;
        avanzoSolo = false;
    }

    public void AvanzoSolo()
    {
        avanzoSolo = true;
    }

    public void DejoDeAvanzar()
    {
        avanzoSolo = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "plataforma_movil")
        {
            Debug.Log(collision.gameObject.tag);
        }



    }

}
