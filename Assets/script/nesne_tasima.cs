using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nesne_tasima : MonoBehaviour
{
    public GameObject p1;

    float hiz = 1.0f;

    private void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position,p1.transform.position,hiz*Time.deltaTime);

    }



}
