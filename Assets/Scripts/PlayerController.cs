using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
