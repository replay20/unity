using UnityEngine;

public class EndTrigger : MonoBehaviour
{

   public GameObject endUI;
   public GameObject defaultUI;

    void OnTriggerEnter2D()
    {
        defaultUI.SetActive(false);
        endUI.SetActive(true);
        Debug.Log("ukonczono");
    }
}
