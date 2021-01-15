using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour
{
    public Sprite image;
    public GameObject obje, preview;
    public Transform sol, sag, alt, yukarı;
    void Start()
    {
        
    }


    void Update()
    {

        Vector3 worldpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject build = Instantiate(obje);
            
            build.transform.localPosition =  Input.mousePosition;

        }


        //if(Input.GetKeyDown(KeyCode.Alpha4))
        //{
        //    print("obje");
        //    Instantiate(obje, sol.position,sol.rotation);
        //}
        //if(Input.GetKeyDown(KeyCode.Alpha6))
        //{
        //    print("obje");
        //    Instantiate(obje, sag.position,sag.rotation);
        //}
        //if(Input.GetKeyDown(KeyCode.Alpha8))
        //{
        //    print("obje");
        //    Instantiate(obje, yukarı.position,yukarı.rotation);
        //}
        //if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    print("obje");
        //    Instantiate(obje, alt.position, alt.rotation);
        //}
    }
}
