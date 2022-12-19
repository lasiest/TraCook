using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransorm;
    private CanvasGroup canvasGroup;

    private Vector2 currentPosition;

    public GameObject saos;

    private bool inPlate = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Piring")
        {
            Debug.Log("test");
            inPlate = true;
        }
    }

    private void Awake()
    {
        rectTransorm = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        rectTransorm.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        transform.position = currentPosition;

        if(inPlate == true)
        {
            saos.SetActive(true);
        }
    }



    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    // Start is called before the first frame update
    void Start()
    {
        currentPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
