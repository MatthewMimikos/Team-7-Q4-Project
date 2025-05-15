using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class wave : MonoBehaviour
{
    public KeyCode wakeywakey;
    public waveData waveData;
    public Transform spawnLoc;
    public float offense;
    int spawnedG; //how many guards were spawned
    int spawnedC; //How many cultists were spawned
    int spawnedEG; //how many Elite Guards were spawned

    float spawnDelayMain = 0;
    float spawnDelay = 0;
    public int happened; //the hit happened. Straight gas





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = spawnLoc.position;
        happened = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (happened == 0 && offense > waveData.offenseLevel)
        {
            causeWave();
            happened++;
        }*/
        if (Input.GetKeyDown(wakeywakey))
        {
            offense = 120;
        }
        if (offense > waveData.offenseLevel && spawnedG < waveData.guardCount)
        {

            Instantiate(waveData.guard, spawnLoc.position, Quaternion.identity);

            spawnedG++;

        }
    }
    public void causeWave()
    {
        /*if (happened == 1)
        {
            spawnDelay -= Time.deltaTime;
            if (spawnDelay <= 0 && spawnedG < waveData.guardCount)
            {

                Instantiate(waveData.guard, spawnLoc.position, Quaternion.identity);

                spawnedG++;
            }
        }*/
    }
}
