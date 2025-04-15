using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class ui : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /*
    A guard found a body!, A miner found a body!

    Guard at the enterance... No way you can knock em out without being detected, Try going around the left
    Alright, no guards here. Make sure that camera doesn't see you.
    Hit that camera with your shovel, that'll probably lure a guard's attention to it
    Just one guard is coming, Hide and knock em out with that shovel
    Got his mask? Good. We can go in without being detected.
    Alright, try to find a way to the mine shaft.
    Argh, Completely forgot about the door. we'll need to get a code from someone here.
    One of the miners has to know today's code, find them.

    Or you can do that I guess...
    Quick! Get his shotgun!
    Guards incoming!
    Find the enterance to the mine
    A security door? Augh, No way we can get the code from someone here, You gonna blast it with dynamite.
    There has to be some dynamite in the guard's room...
    You're gonna need a guard's mask to open that door. Get one from the guards.
    You're gonna need a guard's mask to open that door. Wear it now!
    Alright, light that dynamite near that security door. Make sure the guards don't blow out the fuse
    We're in!
    */
    public GameObject crosshair;

    public TMP_Text fps;
    public TMP_Text info_text;
    public TMP_Text info_text2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float my_fps = Time.frameCount / Time.time;
        fps.text = my_fps.ToString() + " FPS";
    }
}
