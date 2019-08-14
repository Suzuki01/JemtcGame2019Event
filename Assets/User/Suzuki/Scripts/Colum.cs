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
        //↓これはActiveなSceneから同名のGameObjectを参照するはず、この場合一番最初に見つかった同名のGameObjectが返るはず
        //  Piece(clone)など同名のGameObjectが複数存在するから適さない。
        //GameObject obj = GameObject.Find(collider.gameObject.name);

        //↓ColliderのGameObjectへアクセスするならこっち。
        //  基本、ComponentからGameObjectへの参照は簡単にできるよ
        GameObject obj = collider.gameObject;
        SetPiece(obj.GetComponent<Piece>());
        Debug.Log(obj.GetComponent<Piece>().String);
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        piece = null;    
    }
}
