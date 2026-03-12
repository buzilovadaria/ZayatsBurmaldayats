using UnityEngine;
using TMPro;

public class ItemChecker : MonoBehaviour
{
    public int score;
    public GameObject scoreTextObject;
    private TMP_Text tmpText;
    void Start()
    {
        tmpText = scoreTextObject.GetComponent<TMP_Text>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Good")
        {
            score += 1;
           
            Destroy(other.gameObject);
        }
        tmpText.text = score.ToString();
    }
}