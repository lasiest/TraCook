using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitObjectManager : MonoBehaviour
{

    public GameObject piece1;
    public GameObject piece2;
    public GameObject piece3;
    public GameObject piece4;
    public GameObject piece5;
    public GameObject piece1_line;
    public GameObject piece2_line;
    public GameObject piece3_line;
    public GameObject piece4_line;


    void Start()
    {
        piece1.GetComponent<BoxCollider2D>().enabled = true;
        piece2.GetComponent<BoxCollider2D>().enabled = false;
        piece3.GetComponent<BoxCollider2D>().enabled = false;
        piece4.GetComponent<BoxCollider2D>().enabled = false;
        piece5.GetComponent<BoxCollider2D>().enabled = false;
        piece1_line.SetActive(true);
        piece2_line.SetActive(false);
        piece3_line.SetActive(false);
        piece4_line.SetActive(false);
    }

    void Update()
    {
        if(piece1.GetComponent<PickableScript>().enabled == true){
            piece2.GetComponent<BoxCollider2D>().enabled = true;
            piece1_line.SetActive(false);
            piece2_line.SetActive(true);           
        }
        if(piece2.GetComponent<PickableScript>().enabled == true){
            piece3.GetComponent<BoxCollider2D>().enabled = true;
            piece2_line.SetActive(false);
            piece3_line.SetActive(true);
        }
        if(piece3.GetComponent<PickableScript>().enabled == true){
            piece4.GetComponent<BoxCollider2D>().enabled = true;
            piece3_line.SetActive(false);
            piece4_line.SetActive(true);
        }
        if(piece4.GetComponent<PickableScript>().enabled == true){
            piece5.GetComponent<BoxCollider2D>().enabled = true;
            piece4_line.SetActive(false);
        }   
    }
}
