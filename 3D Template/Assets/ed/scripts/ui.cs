using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //TUTORIAL LEVEl / LEVEL 1
    /*
    //SHEALTH
    Guard at the entrance. No way you can knock 'em out without getting detected, Go back around and try going up those rocks.
    Make sure that camera doesn't see you.
    Maybe crawl under the building? (Hold C to crouch)
    You need a guard mask to open that door, hit that camera with your shovel, that'll probably lure a guard's attention to it
    Just one guard is coming, knock em out with that shovel when you see em
    Got his mask? Good. We can go in, and without being detected.
    Alright, try to find a way to the mines.
    Argh, Completely forgot about that security door. we'll need to get a code from someone here.
    We'll need to take a Miner Mask, find one.

    (if you try to leave the level without the camera mask)
    Hey, i think there's one more mask around here that'll help, it's in the building.


    //DETECTED
    Or you can do that I guess...
    Quick! Get his shotgun!
    Guards incoming!
    Find the enterance to the mine
    A security door? Augh, No way we can get the keycard from someone here, You gonna blast it with dynamite.
    There has to be some dynamite in the guard's room...
    You're gonna need a guard's mask to open that door. Get one from the guards.
    You're gonna need a guard's mask to open that door. Wear it now!
    Alright, light that dynamite near that security door. Make sure the guards don't blow out the fuse
    We're in!

    //MINES / LEVEL 2
    
    //SHEALTH
    I remember that you needed an escort to get to the lower layer here, so, we gonna need his mask
    I noticed that the masks look slightly different here and that door didn't let you pass
    We'll need a guard mask from someone in this layer.
    Hey, got some intel, the escort seems to be in an interrogation room...
    I think it's at the door where that rifleman is, on the bridge above. Find a rifleman Mask
    Careful now, sercurity is tight around here.
    We need to disable the sercurity system, find the camera operator.
    He's in there, get him!
    Alright! Go back to that mining area, just don't wear the escort mask just yet.
    Open that door with the escort mask

    //DETECTED
    Really? okay

    */
    public GameObject crosshair;

    public TMP_Text fps;
    public TMP_Text info_text;
    public TMP_Text info_text2;
    public TMP_Text status_text;
    public TMP_Text ammo;

    public RawImage mask_texture;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float my_fps = Time.frameCount / Time.time;
        fps.text = my_fps.ToString() + " FPS";
    }

    public void switch_mask(Texture2D mask)
    {
        mask_texture.texture = mask;
    }
}
