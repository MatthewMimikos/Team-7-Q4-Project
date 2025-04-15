using System;
using TMPro;
using UnityEngine;

public class LoreNoteReading : MonoBehaviour
{
    public GameObject LoreMenu;
    public GameObject LoreReading;
    public bool LoreNote1;
    public bool LoreNote2;
    public bool LoreNote3;
    public bool LoreNote4;
    public bool LoreNote5;
    public bool LoreNote6;
    public bool LoreNote7;
    public bool LoreNote8;

    public TMP_Text LoreNoteText1;
    public TMP_Text LoreNoteText2;
    public TMP_Text LoreNoteText3;
    public TMP_Text LoreNoteText4;
    public TMP_Text LoreNoteText5;
    public TMP_Text LoreNoteText6;
    public TMP_Text LoreNoteText7;
    public TMP_Text LoreNoteText8;

    public void Start()
    {
        LoreReading.SetActive(false);
        LoreNote1 = true;
        LoreNote2 = false;
        LoreNote3 = false;
        LoreNote4 = false;
        LoreNote5 = false;
        LoreNote6 = false;
        LoreNote7 = false;
        LoreNote8 = false;
    }

    public void Update()
    {
        LoreText1();
    }

    public void OpenLore1()
    {
        if (LoreNote1 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
        }
        else
        {
            Console.WriteLine("You don't have that lore note.");
        }
    }

    public void OpenLore2()
    {
        if (LoreNote2 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
        }
    }

    public void OpenLore3()
    {
        if (LoreNote3 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
        }
    }

    public void OpenLore4()
    {
        if (LoreNote4 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
        }
    }

    public void OpenLore5()
    {
        if (LoreNote5 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
        }
    }

    public void OpenLore6()
    {
        if (LoreNote6 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
        }
    }

    public void OpenLore7()
    {
        if (LoreNote7 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
        }
    }

    public void OpenLore8()
    {
        if (LoreNote8 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
        }
    }

    public void LoreText1()
    {
        if (LoreNote1 == true)
        {
            LoreNoteText1.text = "Lore Note 1";
        }
        else
        {
            LoreNoteText1.text = "LOCKED";
        }
    }

    public void LoreText2()
    {
        if (LoreNote2 == true)
        {
            LoreNoteText2.text = "Lore Note 2";
        }
        else
        {
            LoreNoteText2.text = "LOCKED";
        }
    }

    public void LoreText3()
    {
        if (LoreNote3 == true)
        {
            LoreNoteText3.text = "Lore Note 3";
        }
        else
        {
            LoreNoteText3.text = "LOCKED";
        }
    }

    public void LoreText4()
    {
        if (LoreNote4 == true)
        {
            LoreNoteText4.text = "Lore Note 4";
        }
        else
        {
            LoreNoteText4.text = "LOCKED";
        }
    }

    public void LoreText5()
    {
        if (LoreNote5 == true)
        {
            LoreNoteText5.text = "Lore Note 5";
        }
        else
        {
            LoreNoteText5.text = "LOCKED";
        }
    }

    public void LoreText6()
    {
        if (LoreNote6 == true)
        {
            LoreNoteText6.text = "Lore Note 6";
        }
        else
        {
            LoreNoteText6.text = "LOCKED";
        }
    }

    public void LoreText7()
    {
        if (LoreNote7 == true)
        {
            LoreNoteText7.text = "Lore Note 7";
        }
        else
        {
            LoreNoteText7.text = "LOCKED";
        }
    }

    public void LoreText8()
    {
        if (LoreNote8 == true)
        {
            LoreNoteText8.text = "Lore Note 8";
        }
        else
        {
            LoreNoteText8.text = "LOCKED";
        }
    }

    public void CloseLore()
    {
        LoreMenu.SetActive(true);
        LoreReading.SetActive(false);
    }
}
