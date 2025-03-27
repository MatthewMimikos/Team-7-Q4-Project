using System;
using UnityEngine;
using UnityEngine.UI;

public class MaskSwitching : MonoBehaviour
{
    public RawImage Mask1;
    public RawImage Mask2;
    public RawImage Mask3;
    public bool mask1Active;

    public KeyCode useMask;
    public KeyCode noMask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mask2.enabled = false; Mask3.enabled = false;
        mask1Active = false;
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

        if (Input.GetKeyDown(useMask) && Mask1.enabled == true && mask1Active == false)
        {
            GetComponent<PlayerMovement>().moveSpeed = 50;
            mask1Active = true;
        }
        if (Input.GetKeyDown(noMask) && Mask1.enabled && mask1Active == true)
        {
            GetComponent<PlayerMovement>().moveSpeed = 7;
            mask1Active = false;
        }
    }

    void Equip1()
    {
        Mask1.enabled = true;
        Mask2.enabled = false;
        Mask3.enabled = false;
    }
    void Equip2()
    {
        Mask1.enabled = false;
        Mask2.enabled = true;
        Mask3.enabled = false;
    }   
    void Equip3()
    {
        Mask1.enabled = false;
        Mask2.enabled = false;
        Mask3.enabled = true;
    }
}
