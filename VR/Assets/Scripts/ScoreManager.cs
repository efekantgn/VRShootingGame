using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public enum Player
{
    Player1,
    Player2
}
public class ScoreManager : MonoBehaviour
{

    [SerializeField] GameObject ball;
    [SerializeField] GameObject startPoint;
    [SerializeField] TextMeshPro p1Text;
    [SerializeField] TextMeshPro p2Text;
    private int p1Score=0;
    private int p2Score=0;

    // Start is called before the first frame update
   


    public void IncreaseScore(Player player,int amount)
    {
        if (player==Player.Player1)
        {
            p1Score += amount;
        }
        else if (player==Player.Player2)
        {
            p2Score += amount;
        }
        else
        {
            p1Text.text = "Error";
            p2Text.text = "Error";
        }

        UpdateTexts();
        ResetBall();
    }

    private void UpdateTexts()
    {
        p2Text.text = p2Score + " : " + p1Score;
        p1Text.text = p1Score + " : " + p2Score;
       
    }

    private void ResetBall()
    {
        ball.transform.position = startPoint.transform.position;
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
