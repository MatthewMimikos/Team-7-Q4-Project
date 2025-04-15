using System;
using UnityEngine;
using UnityEngine.UI;

public class MaskSwitching : MonoBehaviour
{
    public int currentMask;
    public RawImage Mask1;
    public RawImage Mask2;
    public RawImage Mask3;
    

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Equip1();
        }
        if (Input.GetKeyDown("2"))
        {
            Equip2();
        }
        if (Input.GetKeyDown("3"))
        {
            Equip3();
        }


    }

    void Equip1()
    {
        Mask1.enabled = true;
        Mask2.enabled = false;
        Mask3.enabled = false;
        currentMask = 1;
    }
    void Equip2()
    {
        Mask1.enabled = false;
        Mask2.enabled = true;
        Mask3.enabled = false;
        currentMask = 2;
    }   
    void Equip3()
    {
        Mask1.enabled = false;
        Mask2.enabled = false;
        Mask3.enabled = true;
        currentMask = 3;
    }
}
