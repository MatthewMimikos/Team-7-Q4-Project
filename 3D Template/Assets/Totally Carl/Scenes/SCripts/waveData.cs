using UnityEngine;

[CreateAssetMenu(fileName = "waveData", menuName = "Scriptable Objects/waveData")]
public class waveData : ScriptableObject
{
    public int EGuardcount;
    public int cultistCount;
    public int guardCount;
    public float eguardDelay;

    public float spawnDelay;

    public GameObject EGuard;
    public GameObject cultist;
    public GameObject guard;

    public float offenseLevel; //the amount of offense to cause the wave
    
}
