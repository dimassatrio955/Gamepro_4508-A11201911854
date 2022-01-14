using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI score_textholder;
    public static int score = 0;
    public static int hgscore = 0;

    public TextMeshProUGUI final_score;

    void Start()
    {
        hgscore = score;
        score=0;
    }

    // Update is called once per frame
    void Update()
    {
        score_textholder.text = score.ToString();
        if (score < hgscore)
        {
            final_score.text = hgscore.ToString();  
            //score=0;
        }else
        {
            final_score.text = score.ToString();
        }
    }
}
