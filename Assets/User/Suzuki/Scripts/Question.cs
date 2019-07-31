using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Question : MonoBehaviour
{
    public Sprite image;
    public List<Piece> answer;
    public List<Piece> OtherPiece;
    public AnswerColum answerColum;
    public int pieceIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool IsAnswer = false;


        for(int i = 0; i < pieceIndex; i++)
        {
            if (answerColum.ColumIndex[i].piece == null)
                return;

            if (answer[i].String != answerColum.ColumIndex[i].piece.String)
                break;
            else if (i == pieceIndex - 1)
            {
                IsAnswer = true;
            } 
        }

        if (IsAnswer)
        {
            //カウントアップの関数を呼ぶ
            IsAnswer = false;
            Debug.Log("正解!!!!!");
        }
    }

    void SetAnswer(int key)
    {

    }

    void PieceGenerate(int num)
    {

    }
}
