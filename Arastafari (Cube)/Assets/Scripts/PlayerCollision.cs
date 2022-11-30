using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public AudioSource bamSound;

    void Start()
    {
        bamSound = GetComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
            bamSound.Play();
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}

