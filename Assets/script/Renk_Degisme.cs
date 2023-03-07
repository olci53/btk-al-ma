using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renk_Degisme : MonoBehaviour
{

    public GameObject Kure;

    private int RenkKodu;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RenkKodu = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            RenkKodu = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            RenkKodu = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            RenkKodu = 4;
        }


        switch (RenkKodu)
        {
            case 1 :
                Kure.GetComponent<MeshRenderer>().material.color = Color.black;
                break;

            case 2:
                Kure.GetComponent<MeshRenderer>().material.color = Color.blue;
            break;

            case 3:
                Kure.GetComponent<MeshRenderer>().material.color = Color.green;
                break;

            case 4:
                Kure.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
        }

    }

}
