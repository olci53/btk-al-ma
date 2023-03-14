using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fonkisyonlara_parametre_atamak : MonoBehaviour
{
    public int saglikdurumu;
    public int a;
    public void hasar(int a)
    {
        saglikdurumu -= a;

        if (saglikdurumu < 1)
        {
            saglikdurumu = 0;
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hasar(a);


        }

    }

}
