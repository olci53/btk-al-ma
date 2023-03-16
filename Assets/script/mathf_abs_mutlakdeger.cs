using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mathf_abs_mutlakdeger : MonoBehaviour
{
    private int deger = -10;

    private int x = 5;
    private int y = 15;

    private void Start()
    {
        Debug.Log(Mathf.Abs(deger));

        Debug.Log(Mathf.Abs(x-y));
    }
}
