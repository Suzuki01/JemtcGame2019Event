using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerColum : Question
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

    public void SetColum(int columNum)
    {
        GameObject prefab = (GameObject)Resources.Load("Colum");
        for (int i = 0; i < columNum; i++)
        {
            GameObject obj = Instantiate(prefab, new Vector3(i + 1, 0, 0), Quaternion.identity);
            ColumIndex.Add(obj.GetComponent<Colum>());
        }
    }
}
