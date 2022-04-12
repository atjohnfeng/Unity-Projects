using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionsSeen = 0;
    
    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        correctAnswers++;
    }
}
