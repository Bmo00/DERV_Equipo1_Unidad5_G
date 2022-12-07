using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Quitar_Vida : MonoBehaviour
{
    public int damage;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        damage = 10;
        //cc = GetComponent<CharacterController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.GetComponent<vida_FPC>().vidaPlayer -= damage;
        }
    }
}
