using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour , ISubject
{
    public static GameManager instance;

    private int score = 0;

    private List<IObserver> observers;

    public int Score;

    public int ScoreA { get { return Score; } }

    
    void Awake()

    {
        observers=new List<IObserver>();
        instance = this;
    }
    public static GameManager getInstance()
    {
        return instance;
    }
    public void Update()
    {

        notify();
    }

    public void Button1()
    {
        Score=1;
    }
    public void Button2()
    {
        score = 2;
    }
    public void Button3()
    {
        score = 3;
    }

    public void attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void notify()
    {
        foreach(IObserver observer in observers)
        {
            observer.execute(this);
        }
    }
}
