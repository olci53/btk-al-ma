using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While1 : MonoBehaviour
{

    int adet = 10;

    // while yanl�� yap�l�rsa unity ��k�yor :x



    private void Start()
    {
        while (adet>5)
        {
            Debug.Log(adet);
            adet-=1;
        }
    }

}
