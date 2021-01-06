using UnityEngine;
using UnityEngine.UI;

public class FinalScoreText : MonoBehaviour
{
    public PlayerMovement player;
    public int finalScore;
    public Text scoret;

    void Update()
    {
        finalScore = player.score + (player.playerLife * 100);
        scoret.text = finalScore.ToString();
    }
}
