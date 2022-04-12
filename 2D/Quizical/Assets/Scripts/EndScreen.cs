using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    Scorekeeper scorekeeper;
    // Start is called before the first frame update
    void Start()
    {
        scorekeeper = FindObjectOfType<Scorekeeper>();   
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "Congratulations!\nYou got a score of " + 
                                scorekeeper.CalculateScore() + "%";
    }
}
