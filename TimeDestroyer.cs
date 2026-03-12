using UnityEngine;

public class TimeDestroyer : MonoBehaviour
{
   
    public float aliveTimer = 5f;

    
    void Start()
    {
        Destroy(gameObject, aliveTimer);
    }
}