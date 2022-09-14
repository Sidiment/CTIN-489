using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        score += 10;
        scoreText.text = "Score: " + score;
        Destroy(other.gameObject);
    }
}
