using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public PlayerMovement player;
    public Text scoret;

    void Update()
    {
        scoret.text = player.score.ToString();
    }
}
