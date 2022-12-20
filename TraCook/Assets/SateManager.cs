using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SateManager : MonoBehaviour
{

    public bool move;
    public bool tertusuk;
    public float waktu_tusukan;
    public TitikTajamTusukan titikTajamTusukan;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Tusukan"){
            GetComponent<PickableScript>().enabled = false;
            StartCoroutine(Wait(waktu_tusukan));
            Debug.Log("sentuh tusukan");
        }
    }

    void awake(){
        tertusuk = false;
        GetComponent<PickableScript>().enabled = true;
        titikTajamTusukan = GetComponent<TitikTajamTusukan>();
        move = false;
    }

    void Update()
    {
        waktu_tusukan = titikTajamTusukan.waktu_tusukan;
        if (move == true)
        {
            transform.position = (transform.position + new Vector3(1f, 0, 0) * Time.deltaTime);
        }
    }

    public IEnumerator Wait(float n)
    {
        move = true;
        yield return new WaitForSeconds(n);
        tertusuk = true;
        move = false;
    }

}

