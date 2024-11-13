using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerMovement Option")]
    [SerializeField] public float moveSpeed = 5f; // 이동 속도
    [SerializeField] public float moveInterval = 2f; // 이동 간격 (초)
    [SerializeField] public Vector2 minPosition; // 이동 가능한 최소 위치
    [SerializeField] public Vector2 maxPosition; // 이동 가능한 최대 위치

    private Vector3 targetPosition;
    private Animator animator; // Animator 컴포넌트

    private void Start()
    {
        animator = GetComponent<Animator>();
        // 일정 시간마다 MoveToRandomPosition 함수를 호출합니다.
        InvokeRepeating("MoveToRandomPosition", 0f, moveInterval);
    }

    private void Update()
    {
        // 플레이어를 목표 위치로 이동시킵니다.
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if (transform.position != targetPosition) 
        { 
            animator.SetBool("isWalk", true); 
        } 
        else 
        { 
            animator.SetBool("isWalk", false); 
        }
    }

    private void MoveToRandomPosition()
    {
        // 랜덤한 목표 위치를 설정합니다.
        float randomX = Random.Range(minPosition.x, maxPosition.x);
        float randomY = Random.Range(minPosition.y, maxPosition.y);
        targetPosition = new Vector3(randomX, randomY, transform.position.z);
    }
}
