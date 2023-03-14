using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obje_renk_degistirme : MonoBehaviour
{

    public GameObject kup;


   private void rengidegistir(GameObject obje,Color renk)
    {
        obje.GetComponent<MeshRenderer>().material.color = renk;

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        { 
            
            rengidegistir(kup, Color.red);
        
        }

    }
}
