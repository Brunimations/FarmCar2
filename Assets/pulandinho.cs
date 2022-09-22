using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulandinho : MonoBehaviour
{
    public GameObject corvo;
    public Rigidbody rb;
    public float forcapulo;
    public float puloh;
    public Vector3 pulo;
    public bool pulando;

    [SerializeField] float velocidade;
    public GameObject batatayumyum;
    public bool ebatata; 

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(this);
        }
    } 

    public void Start(){
        batatayumyum = gameObject;
        ebatata = false;
    }
    void Update()
    {
        MovimentoCorvo();
    }
    public void MovimentoCorvo()
    {
        if (ebatata == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, batatayumyum.transform.position, velocidade * Time.deltaTime);
        }  
    }
    

















    //void Start()
    //{
    //    pulo = new Vector3(0f, puloh, 0f);
    //    rb = GetComponent<Rigidbody>();
    //    StartCoroutine(pulodelay());
    //}
    //IEnumerator pulodelay()
    //{
    //    WaitForSeconds espera = new WaitForSeconds(3);
    //    while (pulando == true)
    //    {
    //        yield return espera(2);
    //        rb.AddForce(pulo * forcapulo, ForceMode.Impulse);
    //    }
    //}
}
