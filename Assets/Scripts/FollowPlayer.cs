using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    void Start()
    {
        
    }

    void Update()
    {
        // OFFSET THE CAMERA BEHIND THE PLAYER BY Adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
