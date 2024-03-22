using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BeatMap", menuName = "Rhythum/BeatMap", order = 1)]
public class BeatmapObject : ScriptableObject
{
    public AudioClip Song;
    public string Name;
    public string Description;
    public int BPM;

    public Vector3[] HitObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
