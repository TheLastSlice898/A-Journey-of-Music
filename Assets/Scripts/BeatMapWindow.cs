using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class BeatMapWindow : EditorWindow
{
    static float value = 0.0f;

    public AudioSource Player;
    public AudioClip Song;

    public BeatmapObject Beatmap;

    [MenuItem("Window/Beatmap Editor")]

    public static void ShowWindow()
    {
        GetWindow<BeatMapWindow>("Beatmap Editor");
    }

    // Start is called before the first frame update

    private void CreateGUI()
    {
           
    }

    void OnGUI()
    {
        if (EditorApplication.isPlaying)
        {



            EditorGUILayout.LabelField("Song Length");
            value = EditorGUILayout.Slider(value, 0f, Song.length);
            Player.time = value;

        }
        else // Editor is not playing 
        {
            EditorGUILayout.LabelField("Song Length");
            value = EditorGUILayout.Slider(value, 0f, Song.length);

            Beatmap = EditorGUILayout.ObjectField(Beatmap, typeof(BeatmapObject), false) as BeatmapObject;
            if (Beatmap == null)
            {
                EditorGUILayout.HelpBox("Add beatmap Object", MessageType.Info);
            }
            if (Beatmap != null)
            {
                Beatmap.Name = EditorGUILayout.TextField(Beatmap.Name);
            }


            Player = (AudioSource)FindFirstObjectByType(typeof(AudioSource));
            



        }

    }
    void OnInspectorUpdate()
    {
        if (EditorApplication.isPlaying)
        {
            value = Player.time;
            Repaint();
            
        }
    }
}
