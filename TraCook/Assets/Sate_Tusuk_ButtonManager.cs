using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sate_Tusuk_ButtonManager : MonoBehaviour
{
    public GameObject piece1;
    public GameObject piece2;
    public GameObject piece3;
    public GameObject piece4;

    public GameObject nextSceneButton;

    private void Awake() {
        nextSceneButton.SetActive(false);
    }

    private void Update() {
        if(piece1.GetComponent<SateManager>().tertusuk == true && piece2.GetComponent<SateManager>().tertusuk == true && piece3.GetComponent<SateManager>().tertusuk == true && piece4.GetComponent<SateManager>().tertusuk == true){
            nextSceneButton.SetActive(true);
        }
    }

}
