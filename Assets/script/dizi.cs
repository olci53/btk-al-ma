using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class dizi : MonoBehaviour
{

    public string[] isim;

    public int[] yaslar;

    public string[] isi;

    public int sira;


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            sira = 0;
            if (sira == 0)
                Debug.Log("�sim: " + isim[0] + "Yas: " + yaslar[0] + "��: " + isi[0]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sira = 1;
            if (sira == 1)
                Debug.Log("�sim: " + isim[1] + "Yas: " + yaslar[1] + "��: " + isi[1]);
        }
 
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sira = 2;
            if (sira == 2)
                Debug.Log("�sim: " + isim[2] + "Yas: " + yaslar[2] + "��: " + isi[2]);
        }
       
    }
}
