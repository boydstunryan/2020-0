using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    private Text scoreText;

    // Start is called before the first frame update
    private void Start()
    {
        scoreText = GetComponent<Text>();

        score = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        if (score < 0)
            score = 0;

        scoreText.text = "" + score;
    }

    public static void AddPoints (int pointsToAdd)
    {
        score += pointsToAdd;
    }
}
