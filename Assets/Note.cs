using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float bpm;
    private RectTransform rt;
    public bool hasStarted;

    public float NoteVelocity; // how fast it approaches
    public float NoteTime = 0f; // Time note needs to be hit
    public float NoteApprochRate;
    // Start is called before the first frame update
    void Start()
    {
        rt = GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {

        

        //Debug.Log(Mathf.Lerp(-1000, 0, NoteTime));

        if (!hasStarted)
        {
            if (Input.anyKeyDown)
            {
                hasStarted = false;

            }
            else
            {
                rt.localPosition = new Vector3(NoteTime, 0f, 0f);

            }
        }
    }
}

