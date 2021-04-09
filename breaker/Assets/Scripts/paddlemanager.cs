using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlemanager : MonoBehaviour
{
  
    private void Start()
    {
       
    }
    void Update()
    {
        float anan = Mathf.Clamp((Input.mousePosition.x / Screen.width) * 14 + 1,1.1f,14.9f);
        Vector2 paddle = new Vector2(anan, transform.position.y);
        transform.position = paddle;
    }
}
