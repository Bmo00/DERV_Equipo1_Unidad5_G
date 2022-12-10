using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_Impulso : MonoBehaviour
{
    [SerializeField]
    public Rigidbody rb;
    [SerializeField]
    float velocidad;
    [SerializeField]
    GameObject player;
    float empuje = 5;
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Pendulo")
        {
            rb = GetComponent<Rigidbody>();
            if (player.transform.position.z < empuje)
            {

                rb.AddForce(Vector3.back * velocidad, ForceMode.Impulse);

            }
            else
            {
                rb.AddForce(Vector3.forward * velocidad, ForceMode.Impulse);
            }
        }
    }
}
