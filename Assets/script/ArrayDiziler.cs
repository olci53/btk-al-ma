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
            Debug.Log("�sim: " + isimler[0] +" "+ "Ya��: " + yaslar[0] +" "+ ("T.C: " + T_C[0]));
        }
    }


}
