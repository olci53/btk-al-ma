using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathf_Floor_yuvarlama : MonoBehaviour
{



    [SerializeField] private float x;
    private void Start()
    {
        //Debug.Log(Mathf.Floor(x));             //burada bir altýna çeviriyor mesela "1.8" i  "1" yapýyor

        //Debug.Log(Mathf.Ceil(x));                //burada bir üstüne çeviriyor "1.2" yi  "2" yapýyor

        Debug.Log(Mathf.Round(x));                   //bu normal yuvarlýyor "1.51" i "2" yapýyor  "1.49" u "1" yapýyor
    }


}
