using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScore : MonoBehaviour
{

    private void Awake()
    {
        // is the apple picker high score already exists... read it!
        if(PlayerPrefs.HasKey("ApplePickerHighScore"))
            {
            score = PlayerPrefs.GetInt("ApplePickerHighScore");

            }
        PlayerPrefs.SetInt("ApplePickerHighScore", score);
        

    }

    static public int score = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score" + score;
        //update apple picker high score in playerpref if nessesary
        if (score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        {
            PlayerPrefs.SetInt("ApplePickerHighScore", score);

        }

    }
}
