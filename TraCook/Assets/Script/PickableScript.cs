using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableScript : MonoBehaviour
{
        bool pressed = false;

        void OnMouseDown()
        {
            pressed = true;
            GetComponent<Rigidbody2D>().isKinematic = true;
        }

        void OnMouseUp()
        {
            pressed = false;
            GetComponent<Rigidbody2D>().isKinematic = false;
        }

        // Update is called once per frame
        void Update()
        {
            if(!PauseMenu.isPaused){
                if (pressed)
                {
                    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    transform.position = mousePos;
                }
            }
        }
}
