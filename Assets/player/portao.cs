using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portao : MonoBehaviour
{
    public float ativox=0;
    public float ativoy=0;
    public float ativoz=0;
    public float deativox=0;
    public float deativoy=0;
    public float deativoz=0;
    public bool ativo = false;

    public void Ativo()
    {
        transform.localScale = new Vector3 (ativox,ativoy,ativoz);
    }
    public void Desativo()
    {
        transform.localScale = new Vector3 (deativox,deativoy,deativoz);
    }
}
