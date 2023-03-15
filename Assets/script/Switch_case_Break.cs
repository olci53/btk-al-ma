using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_case_Break : MonoBehaviour
{
    [HideInInspector] public int level1=0;
    [HideInInspector] public int level2=1;
    [HideInInspector] public int level3=2;

    int level;

    private void Update()
    {

        

        switch (level)
        {
            case 0:
                Debug.Log("kolay");
            break;

            case 1:
                Debug.Log("orta");
            break;

            case 2:
                Debug.Log("zor");
            break;


            default:
                Debug.Log("seviye yok");
            break;

            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            level = Random.Range(0, 3);
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            level=55;
        }
    }

}
