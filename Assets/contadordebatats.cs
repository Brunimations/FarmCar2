using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contadordebatats : MonoBehaviour
{
    public int numerodebatatasatual;
    public Text batatatexto;
    

    void Start()
    {
        batatatexto.text = "BATATAS: " + numerodebatatasatual.ToString();
    }

    public void somarbatata()
    {
        numerodebatatasatual = numerodebatatasatual + 1;
        batatatexto.text = "BATATAS: " + numerodebatatasatual.ToString();
    }
}
