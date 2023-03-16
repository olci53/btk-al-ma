using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathf_sin_cos : MonoBehaviour
{

    [SerializeField] private int genislik=1;
    [SerializeField] private float hiz;

    private void Update()
    {
        float x = Mathf.Cos(Time.time*hiz)*genislik;

        float y = Mathf.Sin(Time.time*hiz)*genislik;

        float z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }


}
