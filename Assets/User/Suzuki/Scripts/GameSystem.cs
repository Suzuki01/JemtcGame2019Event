using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public float timeLimit;
    public int answerCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnswerCountUp()
    {
        answerCounter++;
        Debug.Log(answerCounter);
    }
}
