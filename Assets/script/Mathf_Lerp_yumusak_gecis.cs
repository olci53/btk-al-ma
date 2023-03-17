using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Mathf_Lerp_yumusak_gecis : MonoBehaviour
{
    /* [SerializeField] private float a;
     [SerializeField] private float b;
     [SerializeField] private float arttirma;

     private void Update()
     {
         a = Mathf.Lerp(a, b, arttirma);                                  (burada arttirma deðeri % lik çalýþýyor 0.5f mesela %50 oluyor.)

         Debug.Log(a);
     }

     */

    [SerializeField] private float minimum = -1.0f;
    [SerializeField] private float maximum = 1.0f;

    [SerializeField] private float t = 0.0f;

    private void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(minimum, maximum, t), 0, 0);

        t += 0.5f * Time.deltaTime;

        if (t > 1.0f)                                           //burada tersine döndürüyoruz max min deðer oluyor t 0 lanýyor.
        { 
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
    }



}
