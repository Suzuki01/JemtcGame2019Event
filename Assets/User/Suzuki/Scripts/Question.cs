using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

[System.Serializable]
public class Question : GameSystem
{
    public Sprite image;
    public List<Piece> answer;
    public List<Piece> OtherPiece;
    public AnswerColum answerColum;
    public List<Piece> pieceIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        SetAnswer(answer.Count);
        answerColum.GetComponent<AnswerColum>().SetColum(answer.Count);
        PieceGenerate(0);
    }

    // Update is called once per frame
    void Update()
    {
        bool IsAnswer = false;


        for(int i = 0; i < answer.Count; i++)
        {
            if (answerColum.ColumIndex[i].piece == null)
                return;

            if (answer[i].String != answerColum.ColumIndex[i].piece.String)
            {
                Debug.Log(i);
                Debug.Log(answerColum.ColumIndex[i].piece.String);
                Debug.Log(answer[i].String);
                Debug.Log("判定アウト");
                break;
            }
            else if (i == pieceIndex.Count - 1)
            {
                IsAnswer = true;
            } 
        }

        if (IsAnswer)
        {
            AnswerCountUp();
            IsAnswer = false;
            Debug.Log("Answer");
        }
    }

    void SetAnswer(int key)
    {
        GameObject prefab = (GameObject)Resources.Load("AnswerColum");
        GameObject obj = Instantiate(prefab, new Vector3(0,0,0),Quaternion.identity);
        answerColum = obj.GetComponent<AnswerColum>();
    }

    void PieceGenerate(int num)
    {
        GameObject prefab = (GameObject)Resources.Load("Piece");
        for (int i = 0; i < OtherPiece.Count; i++)
        {
            pieceIndex.Add(OtherPiece[i]);
        }

        for (int i = 0; i < answer.Count; i++)
        {
            pieceIndex.Add(answer[i]);            
        }

        // リストをランダムに並べ替える
        pieceIndex = pieceIndex.OrderBy(a => Guid.NewGuid()).ToList();

        int posY = 0;
        int posX = 0;
        for(int i = 0; i < pieceIndex.Count; i++)
        {
            if (i > 5 && i <= 6 || i > 13 && i <= 14)
            {
                posY-= 2;
                posX = -12;
            }

            GameObject obj = Instantiate(prefab, new Vector3(-4 + i * 2 + posX, -3 + posY , 0), Quaternion.identity);
            obj.GetComponent<Piece>().String = pieceIndex[i].String;
        }
    }
}
