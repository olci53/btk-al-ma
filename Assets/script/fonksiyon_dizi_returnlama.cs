using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fonksiyon_dizi_returnlama : MonoBehaviour
{
    public GameObject[] oyuncu;

    GameObject[] butunoyuncular()
    {
        GameObject[] oyuncular = GameObject.FindGameObjectsWithTag("olci");

        foreach (var p in oyuncular) 
        {
         
    
         p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);

        }

        return oyuncular;  


    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        { 
        
            oyuncu = butunoyuncular();
        
        }
    }





}
