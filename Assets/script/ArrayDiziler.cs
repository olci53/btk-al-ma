using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayDiziler : MonoBehaviour
{
    public string[] isimler;
    public int[] yaslar;
    public int[] T_C;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Ýsim: " + isimler[0] +" "+ "Yaþý: " + yaslar[0] +" "+ ("T.C: " + T_C[0]));
        }
    }


}
