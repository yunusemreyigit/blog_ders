using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;

public class game_settings : MonoBehaviour
{
    public Light2D lt;               // ışığın gücü için
    public Slider day_panel;        // gösterge için
    public float time, maxtime;    // zaman, maksimum zaman
    public bool d, n, inc, deinc; //Gündüz, gece, arttır, azalt
    void Start()
    {
        time = maxtime;
    }

    
    void Update()
    {
        Day_Night();
        day_panel.value = (1 / maxtime) * time;    //Alttaki göstergeyi ayarlıyor
    }

    void Day_Night()  // Gece gündüzü ayarlıyor
    {
        if (time >= maxtime)
        {
            deinc = true;
            inc = false;
        }
        if (time <= 0)
        {
            inc = true;
            deinc = false;
        }

        if (time >= maxtime / 3)
        {
            d = true;
            n = false;

        }
        if (time <= maxtime / 3)
        {
            n = true;
            d = false;
        }

        if (deinc)
        {
            time -= Time.deltaTime;
        }
        if (inc)
        {
            time += Time.deltaTime;
        }


        if (n)
        {

            lt.intensity -= Time.deltaTime;
        }
        if (d)
        {
            lt.intensity += Time.deltaTime;
        }
        if (lt.intensity <= 0) lt.intensity = 0;
        if (lt.intensity >= 1) lt.intensity = 1;
    }
}
