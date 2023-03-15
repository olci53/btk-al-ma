using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fonksiyon_vector3 : MonoBehaviour
{

    public Vector3[] pozisyonlar;

    private int rastgeleindex;


    int rastgele()
    {
        return Random.Range(0, pozisyonlar.Length);

    }


    Vector3 koordinatal(int index)
    {
        return pozisyonlar[index];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rastgeleindex = rastgele();

            Debug.Log(rastgeleindex);

            transform.position=koordinatal(rastgeleindex);

        }


    }


}
