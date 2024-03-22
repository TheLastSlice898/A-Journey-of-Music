using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private Image Image;
    [SerializeField] private Sprite PressedSprite;
    [SerializeField] private Sprite ReleasedSprite;

    public KeyCode KeyToPress;
    // Start is called before the first frame update
    void Start()
    {
        Image = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            Image.sprite = PressedSprite;
        }
        if (Input.GetKeyUp(KeyToPress))
        {
            Image.sprite = ReleasedSprite;
        }
    }
}
