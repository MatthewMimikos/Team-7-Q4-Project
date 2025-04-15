using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoreNoteCheck : MonoBehaviour
{
    public LoreNoteReading LNR;

    public TMP_Text LoreNoteText1;
    public TMP_Text LoreNoteText2;
    public TMP_Text LoreNoteText3;
    public TMP_Text LoreNoteText4;
    public TMP_Text LoreNoteText5;
    public TMP_Text LoreNoteText6;
    public TMP_Text LoreNoteText7;
    public TMP_Text LoreNoteText8;

    public void CheckLN1()
    {
        if (LNR.LoreNote1 == true)
        {
            LoreNoteText1.text = "Lore Note 1";
        }
        else
        {
            LoreNoteText1.text = "LOCKED";
        }
    }
}
