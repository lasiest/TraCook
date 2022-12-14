using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitableObject : MonoBehaviour
{

    public bool clicked;
    public bool move;

    void Start()
    {
        GetComponent<PickableScript>().enabled = false;
        clicked = false;
        move = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!PauseMenu.isPaused)
        {
            if (move == true)
            {
                transform.position = (transform.position + new Vector3(-0.001f, 0, 0));
            }
        }
        /*
        if (Input.GetMouseButtonDown(0) && !clicked)
        {
            float flag = 0f;
            clicked = true;
            while(flag <= 10)
            {
                transform.position = new Vector3(-1, 0, 0);
                flag++;
            }
        }
        */
    }
    
    void OnMouseDown()
    {
        if(!PauseMenu.isPaused){
        if (!clicked)
        {
            clicked = true;
            /*
            double flag = 0f;
            Debug.Log("Clicked");
            clicked = true;
            */
            StartCoroutine(Wait());
            /*
            while (flag <= 10)
            { 
                transform.position = transform.position + new Vector3(-1,0,0);
                Debug.Log(transform.position);
                flag++;
            }
            */
        }
        }
    }

    public IEnumerator Wait()
    {
        if(!PauseMenu.isPaused){
            move = true;
            yield return new WaitForSeconds(1f);
            move = false;
            GetComponent<BoxCollider2D>().offset = new Vector2(0, 0);
            GetComponent<BoxCollider2D>().size = new Vector2(1, 1);
            GetComponent<PickableScript>().enabled = true;
        } 
    }
}
