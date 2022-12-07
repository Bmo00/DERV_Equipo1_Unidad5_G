using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Quitar_vida_bate : MonoBehaviour
{
    public int damage;
    public GameObject Enemigo1;
    public GameObject Enemigo2;
    public GameObject Enemigo3;
    public int zombies_derribados;
    // Start is called before the first frame update
    void Start()
    {
        zombies_derribados = 0;
        damage = 20;
        //cc = GetComponent<CharacterController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo1")
        {
            Enemigo1.GetComponent<vida_enemigo_1>().vidaEnemigo -= damage;
            if (Enemigo1.GetComponent<vida_enemigo_1>().vidaEnemigo <= 0)
            {
                zombies_derribados++;
                Debug.Log("ZOMBIES DERRIBADOS: " + zombies_derribados);
            }
        }
        else if (other.tag == "Enemigo2")
        {
            Enemigo2.GetComponent<vida_enemigo_2>().vidaEnemigo -= damage;
            if (Enemigo2.GetComponent<vida_enemigo_2>().vidaEnemigo <= 0)
            {
                zombies_derribados++;
                Debug.Log("ZOMBIES DERRIBADOS: " + zombies_derribados);
            }
        }
        else if (other.tag == "Enemigo3")
        {
            Enemigo3.GetComponent<vida_enemigo_3>().vidaEnemigo -= damage;
            if (Enemigo3.GetComponent<vida_enemigo_3>().vidaEnemigo <= 0)
            {
                zombies_derribados++;
                Debug.Log("ZOMBIES DERRIBADOS: " + zombies_derribados);
            }
        }
    }
}
