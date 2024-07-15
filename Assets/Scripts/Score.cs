using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Text Scoretext;
    int myscore = 0;
    public TMP_Text finalScoreText ;


    // Update is called once per frame
    void Update()
    {
        Scoretext.text = myscore.ToString();
        finalScoreText.text ="Score:"+ myscore.ToString();
    }
    public void AddScore(int score)
    {
        myscore = myscore + score;
    }
}
