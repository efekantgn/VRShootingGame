using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Goal : MonoBehaviour
{
    // Start is called before the first frame update
    private ScoreManager scoreManager;
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            scoreManager.IncreaseScore(Player.Player2,1);

        }

    }
}
