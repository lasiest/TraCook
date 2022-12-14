using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitikTajamTusukan : MonoBehaviour
{

    public float waktu_tusukan = 13f;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "sateCube"){
            waktu_tusukan -= 1.3f;
        }
    }
}
