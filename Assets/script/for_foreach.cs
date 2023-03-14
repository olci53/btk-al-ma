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
            foreach(var isim in isimler)                           // burada isimler deki elemanlarýn hepsini tek tek isim adý altýnda bir deðiþkene atýyor tek tek atadýðý için liste gibi çýkýyor. 
            {
                Debug.Log(isim);

            }


        }

    }
}
