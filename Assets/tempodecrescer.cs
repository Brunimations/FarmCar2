using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempodecrescer : MonoBehaviour
{
    float tempoatual;
    public float tempoinicial;
    bool colhivel = false;

    public float fase1x=0;
    public float fase1y=0;
    public float fase1z=0;

    public float fase2x=0;
    public float fase2y=0;
    public float fase2z=0;

    public float fase3x=0;
    public float fase3y=0;
    public float fase3z=0;

    public float fase4x=0;
    public float fase4y=0;
    public float fase4z=0;

    public GameObject batatabraba;
    public GameObject obroto;
    public pulandinho corvinho; 

    void Start()
    {
        tempoatual = tempoinicial;
        corvinho=GameObject.Find("Corvo").GetComponent<pulandinho>();
        corvinho.ebatata = true;
        corvinho.batatayumyum = gameObject;
    }
    void Update()
    {
        tempoatual -= 1 * Time.deltaTime;


        if(tempoatual<=0)
        {
            transform.localScale = new Vector3 (fase4x,fase4y,fase4z);
            batatabraba.SetActive(true);
            Maduro();
        }else
        if(tempoatual<=10)
        {
            transform.localScale = new Vector3 (fase3x,fase3y,fase3z);
        }else
        if(tempoatual<=20)
        {
            transform.localScale = new Vector3 (fase2x,fase2y,fase2z);
        }else        
        if(tempoatual<=30)
        {
            transform.localScale = new Vector3 (fase1x,fase1y,fase1z);
        }
    }
    void Maduro(){
        colhivel = true;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && colhivel == true)
        {
            Destroy(obroto);
        }
                if(other.gameObject.tag == "pombo")
        {
            Destroy(obroto);
        }
    }  
    

}
