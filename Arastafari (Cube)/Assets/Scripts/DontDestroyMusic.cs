using UnityEngine;

public class DontDestroyMusic : MonoBehaviour
{
    public void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
