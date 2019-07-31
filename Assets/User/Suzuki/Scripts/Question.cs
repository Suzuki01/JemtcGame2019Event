using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[System.Serializable]
public class Question : GameSystem
{
    public Sprite image;
    public List<Piece> answer;
    public List<Piece> OtherPiece;
    public AnswerColum answerColum;
    public int pieceIndex;
    
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
            AnswerCountUp();
            IsAnswer = false;
            
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
        for(int i = 0; i < OtherPiece.Count; i++)
        {
            GameObject prefab = (GameObject)Resources.Load("Piece");
            GameObject obj = Instantiate(prefab, new Vector3(i + i, i + i, 0), Quaternion.identity);
            Piece piece = obj.GetComponent<Piece>();
            piece.String = OtherPiece[i].String;
        }

        for (int i = 0; i < answer.Count; i++)
        {
            GameObject prefab = (GameObject)Resources.Load("Piece");
            GameObject obj = Instantiate(prefab, new Vector3(i + i, i + i, 0), Quaternion.identity);
            Piece piece = obj.GetComponent<Piece>();
            piece.String = answer[i].String;
        }
    }
}
