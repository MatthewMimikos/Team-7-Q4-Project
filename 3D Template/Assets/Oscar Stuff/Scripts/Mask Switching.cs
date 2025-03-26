using System;
using UnityEngine;
using UnityEngine.UI;

public class MaskSwitching : MonoBehaviour
{
    public RawImage Mask1;
    public RawImage Mask2;
    public RawImage Mask3;
    public bool maskActive;

    public KeyCode useMask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mask2.enabled = false; Mask3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Mask1.enabled = true;
            Mask2.enabled = false;
            Mask3.enabled = false;
        }
        if (Input.GetKeyDown("2"))
        {
            Mask1.enabled = false;
            Mask2.enabled = true;
            Mask3.enabled = false;
        }
        if (Input.GetKeyDown("3"))
        {
            Mask1.enabled = false;
            Mask2.enabled = false;
            Mask3.enabled = true;
        }
        if (Mask1.enabled == true)
        {
            Equip1();
        }
        else if (Mask2.enabled == true)
        {
            Equip2();
        }
        else if (Mask3.enabled == true)
        {
            Equip3();
        }
    }

    void Equip1()
    {


        if (Input.GetKeyDown(useMask) && Mask1.enabled == true)
        {
            GetComponent<PlayerMovement>().moveSpeed = 50;
            maskActive = true;
        }
        if (Input.GetKeyDown(useMask) && maskActive == true)
        {
            GetComponent<PlayerMovement>().moveSpeed = 8;
            maskActive = false;
        }
    }
    void Equip2()
    {

    }   
    void Equip3()
    {

    }
}
