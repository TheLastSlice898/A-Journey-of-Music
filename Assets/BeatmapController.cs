using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BeatmapController : MonoBehaviour
{
    [SerializeField] private float _bpm;
    [SerializeField] private AudioSource _source;
    [SerializeField] private Beats[] _beats;

    public BeatmapObject CurrentBeatMap;
    public float Beatmaptotalsamples;
    private void Update()
    {
        Beatmaptotalsamples = (_source.timeSamples / _source.clip.frequency);
        
        Debug.Log(Beatmaptotalsamples);
    }

    public void SetNewTrack(BeatmapObject newtrack)
    {
        _bpm = newtrack.BPM;
        _source.clip = newtrack.Song;
    }

    [System.Serializable]
    public class Beats
    {
        [SerializeField] private float _Steps;
        [SerializeField] private UnityEvent _trigger;

        private int _lastInterval;
        public float GetBeatLength(float bpm)
        {
            return 60/ bpm * _Steps;
        }

        public void CheckforNewInterval(float interval)
        {
            if (Mathf.FloorToInt(interval) != _lastInterval) 
            { 
            _lastInterval = Mathf.FloorToInt(interval);
            _trigger.Invoke();
            }
        }
    }






}
