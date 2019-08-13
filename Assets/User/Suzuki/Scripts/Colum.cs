using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colum : MonoBehaviour
{
    public Piece piece;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetPiece(Piece pce)
    {
        piece = pce;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject obj = GameObject.Find(collider.gameObject.name);
        SetPiece(obj.GetComponent<Piece>());
        Debug.Log(obj.GetComponent<Piece>().String);
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        piece = null;    
    }
}
