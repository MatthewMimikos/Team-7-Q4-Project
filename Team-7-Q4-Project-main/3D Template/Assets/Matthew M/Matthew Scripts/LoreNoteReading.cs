using System;
using TMPro;
using UnityEngine;

public class LoreNoteReading : MonoBehaviour
{
    public GameObject LoreMenu;
    public GameObject LoreReading;
    public TMP_Text LoreNoteName;
    public TMP_Text LoreNoteContent;
    public TMP_Text LoreNoteSigning;

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

    public string LoreNoteTitle1;
    public string LoreNoteTitle2;
    public string LoreNoteTitle3;
    public string LoreNoteTitle4;
    public string LoreNoteTitle5;
    public string LoreNoteTitle6;
    public string LoreNoteTitle7;
    public string LoreNoteTitle8;

    public string LoreNoteContent1;
    public string LoreNoteContent2;
    public string LoreNoteContent3;
    public string LoreNoteContent4;
    public string LoreNoteContent5;
    public string LoreNoteContent6;
    public string LoreNoteContent7;
    public string LoreNoteContent8;

    public string WrittenBy1;
    public string WrittenBy2;
    public string WrittenBy3;
    public string WrittenBy4;
    public string WrittenBy5;
    public string WrittenBy6;
    public string WrittenBy7;
    public string WrittenBy8;

    public void Start()
    {
        LoreReading.SetActive(false);
        LoreNote1 = true;
        LoreNote2 = true;
        LoreNote3 = true;
        LoreNote4 = true;
        LoreNote5 = true;
        LoreNote6 = true;
        LoreNote7 = true;
        LoreNote8 = true;
    }

    public void Update()
    {
        LoreText1();
        LoreText2();
        LoreText3();
        LoreText4();
        LoreText5();
        LoreText6();
        LoreText7();
        LoreText8();
    }

    public void OpenLore1()
    {
        if (LoreNote1 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
            LoreNoteName.text = LoreNoteTitle1;
            LoreNoteContent.text = LoreNoteContent1;
            LoreNoteSigning.text = WrittenBy1;
        }
    }

    public void OpenLore2()
    {
        if (LoreNote2 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
            LoreNoteName.text = LoreNoteTitle2;
            LoreNoteContent.text = LoreNoteContent2;
            LoreNoteSigning.text = WrittenBy2;
        }
    }

    public void OpenLore3()
    {
        if (LoreNote3 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
            LoreNoteName.text = LoreNoteTitle3;
            LoreNoteContent.text = LoreNoteContent3;
            LoreNoteSigning.text = WrittenBy3;
        }
    }

    public void OpenLore4()
    {
        if (LoreNote4 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
            LoreNoteName.text = LoreNoteTitle4;
            LoreNoteContent.text = LoreNoteContent4;
            LoreNoteSigning.text = WrittenBy4;
        }
    }

    public void OpenLore5()
    {
        if (LoreNote5 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
            LoreNoteName.text = LoreNoteTitle5;
            LoreNoteContent.text = LoreNoteContent5;
            LoreNoteSigning.text = WrittenBy5;
        }
    }

    public void OpenLore6()
    {
        if (LoreNote6 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
            LoreNoteName.text = LoreNoteTitle6;
            LoreNoteContent.text = LoreNoteContent6;
            LoreNoteSigning.text = WrittenBy6;
        }
    }

    public void OpenLore7()
    {
        if (LoreNote7 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
            LoreNoteName.text = LoreNoteTitle7;
            LoreNoteContent.text = LoreNoteContent7;
            LoreNoteSigning.text = WrittenBy7;
        }
    }

    public void OpenLore8()
    {
        if (LoreNote8 == true)
        {
            LoreMenu.SetActive(false);
            LoreReading.SetActive(true);
            LoreNoteName.text = LoreNoteTitle8;
            LoreNoteContent.text = LoreNoteContent8;
            LoreNoteSigning.text = WrittenBy8;
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
