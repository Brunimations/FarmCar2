using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abreporta : MonoBehaviour
{
    public GameObject porta;
    public portao portaoescalonavel;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            portaoescalonavel.Ativo();
        }
    }   
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            portaoescalonavel.Desativo();
        }
    }
}
