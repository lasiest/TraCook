using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background_randomizer : MonoBehaviour
{
    public Image background;
    public Sprite[] sprites;

    public int x;

    void Start()
    {
        x = Random.Range(0,15);
        background.sprite = sprites[x];
    }

}
