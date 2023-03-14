using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fonksiyon_topla : MonoBehaviour
{
    public int x;
    public int y;

    private int topla()
    {
        return x + y;
    }

    private void Start()
    {
        Debug.Log("Toplam: " + topla());

    }

}
