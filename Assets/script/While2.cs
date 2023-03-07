using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class While2 : MonoBehaviour
{

    //IEnumerator 



    IEnumerator dongu()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f);

            Debug.Log("Olci53");



        }

       
    }

    private void Start()
    {
        
        StartCoroutine(dongu());        
    }

}
