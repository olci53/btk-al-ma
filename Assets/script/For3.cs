using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For3 : MonoBehaviour
{
    private void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            Debug.Log(i);

            if(i == 53)
            {
                break;
            }

        }


    }
}
