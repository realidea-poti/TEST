using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float speed = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            speed += 1;
        }
        
        transform.Rotate(0,0,speed);
        speed *= 0.98f;
    }
}
