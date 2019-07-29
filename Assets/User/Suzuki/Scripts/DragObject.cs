using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour
{
    RectTransform Tr;
    private Vector3 screenPoint;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + offset;
        transform.position = currentPosition;
    }

    
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log(1);
    }

    // ドラック中に呼ばれる.
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log(2);
    }

    // ドラックが終了したとき呼ばれる.
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log(3);
    }
}
