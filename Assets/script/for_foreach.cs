using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for_foreach : MonoBehaviour
{
    public string[] isimler;




    private void Update()
    {
      /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                Debug.Log("isimler: " + isimler[i]);
            }
 


        }

        */





        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach(var isim in isimler)                           // burada isimler deki elemanlar�n hepsini tek tek isim ad� alt�nda bir de�i�kene at�yor tek tek atad��� i�in liste gibi ��k�yor. 
            {
                Debug.Log(isim);

            }


        }

    }
}
