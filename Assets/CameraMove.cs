using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    private Vector3 pos = new Vector3(0, 15, -10);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = player.transform.position + pos;
    }
}
