using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathf_LerpAngle_cevirme : MonoBehaviour
{
    float minangle = 0.0f;
    float maxangle = 0.0f;

    private void Update()
    {
        float angle = Mathf.LerpAngle(minangle, maxangle, Time.time);

        transform.eulerAngles = new Vector3(0, angle, 0);                         //döndürme

        maxangle += 0.5f;                                                         //sürekli dönmesi için
    }


}
