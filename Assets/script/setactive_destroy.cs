using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class setactive_destroy : MonoBehaviour
{
    public GameObject kup;


    private void Update()
    {
        calis();
    }


    void calis()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            kup.SetActive(false);                                                     //setactive objeyi sahnede görünürlüðünü açýyor yada kapatýyor oda true flase ile oluyor.

        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            kup.SetActive(true);
        }

        if (Input.GetKeyDown (KeyCode.D))
        {
            Destroy(kup,3f);                                                         //destroy da 3f ne kadar süre sonra yok olucaðýný belirtiyor bomba geri sayýmý gibi.
        }
     }
        
}
