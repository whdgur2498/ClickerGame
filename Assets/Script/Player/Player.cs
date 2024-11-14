using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Animator animator;
    private Text gelatinText; // 재화량을 표시할 텍스트
    private int gelatinAmount = 0; // 재화량

    void Start()
    {
        animator = GetComponent<Animator>();
        gelatinText = GameObject.Find("JellyCount").GetComponent<Text>(); // JellyCount 텍스트 컴포넌트를 찾아 할당
        UpdateGelatinText(); // 초기 재화량 표시
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
        gelatinAmount++; // 재화량 증가
        UpdateGelatinText(); // 텍스트 업데이트
    }

    void UpdateGelatinText()
    {
        gelatinText.text = gelatinAmount.ToString(); // 숫자만 표시
    }
}
