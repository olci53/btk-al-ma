using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foreach_dizi_küpler_üzerinde_calisma : MonoBehaviour
{
    [SerializeField] GameObject[] kupler;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var kup in kupler)
                kup.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            foreach (var kup in kupler)
                kup.GetComponent<MeshRenderer>().material.color = Color.green;
        }    
    }




}
