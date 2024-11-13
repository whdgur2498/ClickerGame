using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerMovement Option")]
    [SerializeField] public float moveSpeed = 5f; // �̵� �ӵ�
    [SerializeField] public float moveInterval = 2f; // �̵� ���� (��)
    [SerializeField] public Vector2 minPosition; // �̵� ������ �ּ� ��ġ
    [SerializeField] public Vector2 maxPosition; // �̵� ������ �ִ� ��ġ

    private Vector3 targetPosition;
    private Animator animator; // Animator ������Ʈ

    private void Start()
    {
        animator = GetComponent<Animator>();
        // ���� �ð����� MoveToRandomPosition �Լ��� ȣ���մϴ�.
        InvokeRepeating("MoveToRandomPosition", 0f, moveInterval);
    }

    private void Update()
    {
        // �÷��̾ ��ǥ ��ġ�� �̵���ŵ�ϴ�.
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
        // ������ ��ǥ ��ġ�� �����մϴ�.
        float randomX = Random.Range(minPosition.x, maxPosition.x);
        float randomY = Random.Range(minPosition.y, maxPosition.y);
        targetPosition = new Vector3(randomX, randomY, transform.position.z);
    }
}
