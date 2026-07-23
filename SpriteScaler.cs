using UnityEngine;

public class SpriteScaler : MonoBehaviour
{
    private Transform tf;
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = transform;
    }

    void Update()
    {
    
     if (Input.GetKey(KeyCode.W))
        {
         tf.position = tf.position + Vector3.up * moveSpeed * Time.deltaTime;
         Debug.Log("Pressing W key");
        }
    }
}
