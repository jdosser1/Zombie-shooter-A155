using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public delegate void SendScore(int playerScore);
    public static event SendScore OnSendScore;

    public int score = 10;

    public void OnDestroy()
    {
        if (OnSendScore != null)
        {
            OnSendScore(score);
        }
    }
}
