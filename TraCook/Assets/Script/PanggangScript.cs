using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanggangScript : MonoBehaviour
{
    Renderer rend;
    [SerializeField] [Range(0f, 5f)]float lerpTime;
    [SerializeField] Color myColor;

    public bool manggang = false;

    void Start()
    {
        manggang = false;
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if(!PauseMenu.isPaused){
            if(manggang == true)
            {
                rend.material.color = Color.Lerp(rend.material.color, myColor, lerpTime);
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Panggangan")
        {
            Debug.Log("Masuk Pangganan");
            manggang = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Panggangan")
        {
            Debug.Log("Keluar Pangganan");
            manggang = false;
        }
    }

}
