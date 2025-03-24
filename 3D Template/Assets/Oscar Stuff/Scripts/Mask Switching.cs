using UnityEngine;
using UnityEngine.UI;

public class MaskSwitching : MonoBehaviour
{
    public RawImage Mask1;
    public GameObject Mask2;
    public GameObject Mask3;
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
        Mask2.SetActive(false);
        Mask3.SetActive(false);
    }
    void Equip2()
    {
        Mask1.enabled = false;
        Mask2.SetActive(true);
        Mask3.SetActive(false);
    }   
    void Equip3()
    {
        Mask1.enabled = false;
        Mask2.SetActive(false);
        Mask3.SetActive(true);
    }
}
