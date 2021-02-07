using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public GameManager gameManager;
    private Rigidbody playerRigidbody;

    // 게임이 처음 시작되었을 때 한번 실행
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // 화면이 한번 깜빡일때 한번 실행
    void Update()
    {
        if (gameManager.isGameOver == true)
        {
            return;
        }
        // -1 ~ +1
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        float fallSpeed = playerRigidbody.velocity.y;
        velocity = velocity * speed;
        velocity.y = fallSpeed;
        playerRigidbody.velocity = velocity;



        //발사 기능 - "FIre" - 마우스 왼쪽 버튼

        //if(입력("Fire")
        //         //총알을 발사 
    }
}
