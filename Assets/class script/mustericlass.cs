using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class mustericlass
{
    public string ad;
    public string soyad;
    public string memleket;
    public int t_c;

    public mustericlass(string ad, string soyad, string memleket, int t_c) 
    {
        this.ad = ad;   
        this.soyad = soyad;
        this.memleket = memleket;
        this.t_c = t_c;

    }
}
