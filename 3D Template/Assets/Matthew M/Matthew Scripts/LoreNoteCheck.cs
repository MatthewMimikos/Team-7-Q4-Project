using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoreNoteCheck : MonoBehaviour
{
    public bool LoreNote1 = false;
    public bool LoreNote2 = false;
    public bool LoreNote3 = false;
    public bool LoreNote4 = false;
    public bool LoreNote5 = false;
    public bool LoreNote6 = false;
    public bool LoreNote7 = false;
    public bool LoreNote8 = false;

    public TMP_Text LoreNoteText1;
    public TMP_Text LoreNoteText2;
    public TMP_Text LoreNoteText3;
    public TMP_Text LoreNoteText4;
    public TMP_Text LoreNoteText5;
    public TMP_Text LoreNoteText6;
    public TMP_Text LoreNoteText7;
    public TMP_Text LoreNoteText8;

    public Button LoreNoteImage1;
    public Button LoreNoteImage2;
    public Button LoreNoteImage3;
    public Button LoreNoteImage4;
    public Button LoreNoteImage5;
    public Button LoreNoteImage6;
    public Button LoreNoteImage7;
    public Button LoreNoteImage8;

    public void CheckLN1()
    {
        if (LoreNote1)
        {
            LoreNoteText1.text = "Lore Note 1";
        }
        else
        {
            LoreNoteText1.text = "LOCKED";
        }
    }

    public void Update()
    {
        CheckLN1();
    }
}
