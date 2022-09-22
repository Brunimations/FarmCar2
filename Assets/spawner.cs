using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] Transform[] ninho;
    [SerializeField] GameObject pombo;
    void Start()
    {
        InvokeRepeating("Nascepombo", 0.5f, 0.5f);
    }
    public void Nascepombo()
    {
        int index = Random.Range(0, ninho.Length);
        Instantiate(pombo, ninho[index].position, Quaternion.identity);
    }
}
