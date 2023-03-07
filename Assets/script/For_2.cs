using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class For_2 : MonoBehaviour
{

    public int adet;

   IEnumerator Adetarttir()
    {
        for(int i = 0; i < 100; i+=1)
        {
            adet+= 2;
            

            yield return new WaitForSeconds(0.5f);
            Debug.Log(adet);
        }
    }


    private void Start()
    {
        StartCoroutine(Adetarttir());

        
    }
}

