using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathf_Floor_yuvarlama : MonoBehaviour
{



    [SerializeField] private float x;
    private void Start()
    {
        //Debug.Log(Mathf.Floor(x));             //burada bir alt�na �eviriyor mesela "1.8" i  "1" yap�yor

        //Debug.Log(Mathf.Ceil(x));                //burada bir �st�ne �eviriyor "1.2" yi  "2" yap�yor

        Debug.Log(Mathf.Round(x));                   //bu normal yuvarl�yor "1.51" i "2" yap�yor  "1.49" u "1" yap�yor
    }


}
