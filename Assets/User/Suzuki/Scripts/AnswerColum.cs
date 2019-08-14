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

        return null;
    }

    public void SetColum(int columNum)
    {
        GameObject prefab = (GameObject)Resources.Load("Colum");
        float width = 0.0f;
        for (int i = 0; i < columNum; i++)
        {
            if (columNum % 2 == 0)
            {
                if (i == 0)
                {
                    width = -2 * (columNum / 2) + 2 * i;
                    if (columNum == 4)
                        width -= 2.0f;
                }
                else
                {
                    width += 4.0f;
                }
            }
            else
            {
                if (i == 0)
                {  
                    width = -2 * (columNum / 2) + 2 * i - 1;
                    if (columNum == 5)
                        width -= 1;
                }
                else
                {
                    width += 3.0f;
                }

            }
            GameObject obj = Instantiate(prefab, new Vector3(width, 0, 0), Quaternion.identity);
            ColumIndex.Add(obj.GetComponent<Colum>());
        }
    }
}
