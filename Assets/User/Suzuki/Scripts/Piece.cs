using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class Piece : MonoBehaviour {

    public Sprite shape;
    public string String;
    public ShapeType.SHAPE_TYPE shapeType;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().sprite = shape;
        GameObject obj;
        this.gameObject.transform.Find("Canvas").gameObject.transform.Find("Text (TMP)").gameObject.GetComponent<TextMeshProUGUI>().text = String;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
