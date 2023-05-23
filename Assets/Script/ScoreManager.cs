using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour,  IObserver 
{
    [SerializeField] TextMeshProUGUI scorecanva;
    [SerializeField] float Score;
    private void Awake()
    {
        GameManager.getInstance().attach(this);
    }

    void Update()
    {
        scorecanva.text = "Score" + Score;
    }

    public void execute(ISubject subject)
    {
        if (subject is GameManager)
        {
            Score = ((GameManager)subject).ScoreA;
        }
    }
     
   
}
