using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int score = 0;

    [SerializeField] TextMeshProUGUI scorecanva;
    void Awake()

    {
        instance = this;
    }
    public static GameManager getInstance()
    {
        return instance;
    }
   

}
