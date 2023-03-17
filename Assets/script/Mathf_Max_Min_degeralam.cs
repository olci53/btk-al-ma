using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathf_Max_Min_degeralam : MonoBehaviour
{

    public float a;
    public float b;
    public float c;
    public float d;
    public float e;
    public float f;


    private void Start()
    {
        Debug.Log(Mathf.Max(a, b, c, d, e, f));                            //max, min deðer alma
        Debug.Log(Mathf.Min(a, b, c, d, e, f));
    }

}
