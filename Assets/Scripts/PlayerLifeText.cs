using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeText : MonoBehaviour
{
    public PlayerMovement player;
    public Text life;

    void Update()
    {
        life.text = player.playerLife.ToString();
    }
}
