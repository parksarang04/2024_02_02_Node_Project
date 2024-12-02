using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isMyPlayer = false;
    public float moveSpeed = 5.0f;

    public void SetAsMyPlayer()
    {
        isMyPlayer = true;
    }
    void Start()
    {
        if (isMyPlayer) //내 플레이어 일 때 만 움직임
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(horizontal, 0,vertical);
            transform.Translate(movement*moveSpeed*Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
