using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Animator animator;
    private Text gelatinText; // ��ȭ���� ǥ���� �ؽ�Ʈ
    private int gelatinAmount = 0; // ��ȭ��

    void Start()
    {
        animator = GetComponent<Animator>();
        gelatinText = GameObject.Find("JellyCount").GetComponent<Text>(); // JellyCount �ؽ�Ʈ ������Ʈ�� ã�� �Ҵ�
        UpdateGelatinText(); // �ʱ� ��ȭ�� ǥ��
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = GetComponent<Collider2D>();

            if (collider.OverlapPoint(mousePosition))
            {
                SimulateClick();
            }
        }
    }

    public void SimulateClick() 
    {
        animator.SetTrigger("doTouch");
        IncreaseGelatin();
    }

    void IncreaseGelatin()
    {
        gelatinAmount++; // ��ȭ�� ����
        UpdateGelatinText(); // �ؽ�Ʈ ������Ʈ
    }

    void UpdateGelatinText()
    {
        gelatinText.text = gelatinAmount.ToString(); // ���ڸ� ǥ��
    }
}
