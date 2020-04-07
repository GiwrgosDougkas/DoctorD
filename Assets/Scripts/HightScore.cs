using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HightScore : MonoBehaviour
{
    public static int highscore;
        Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();

        highscore = PlayerPrefs.GetInt("highscore", highscore);
        text.text = "High Score:" + highscore;

    }

    // Update is called once per frame
    void Update()
    {
        if (Score.scoreValue > highscore) {
            highscore = Score.scoreValue;
            

            PlayerPrefs.SetInt("highscore", highscore); 
        }
    }
    void OnDestroy()
    {
        PlayerPrefs.SetInt("highscore", highscore);
        PlayerPrefs.Save();
        Score.scoreValue = 0;
       
    }
}
