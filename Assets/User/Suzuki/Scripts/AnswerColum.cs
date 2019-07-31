using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerColum : MonoBehaviour
{
    public List<Colum> ColumIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetColums();
    }

    public List<Colum> GetColums()
    {
        Colum[] colums = GetComponents<Colum>();
        Debug.Log(colums);

        return null;
    }

    void SetColum(int columNum)
    {
        ColumIndex[columNum] = GetComponentInChildren<Colum>();
    }
}
