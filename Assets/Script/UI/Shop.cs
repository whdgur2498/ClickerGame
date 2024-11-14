using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Player player; // Player 오브젝트 참조
    public Text goldText; // Gold 재화량을 표시할 텍스트
    private int gold = 1000; // 초기 Gold 재화량

    void Start()
    {
        goldText = GameObject.Find("GoldCount").GetComponent<Text>();
        UpdateGoldText(); // 초기 Gold 재화량 표시
    }

    void UpdateGoldText()
    {
        goldText.text = gold.ToString(); // Gold 재화량 업데이트
    }

    public void OnAutoClickButton()
    {
        if (gold >= 100)
        {
            gold -= 100; // Gold 재화에서 100 차감
            UpdateGoldText(); // Gold 재화량 업데이트
            StartCoroutine(AutoClickCoroutine()); // Coroutine 시작
        }
        else
        {
            Debug.Log("Not enough Gold!");
        }
    }

    IEnumerator AutoClickCoroutine()
    {
        for (int i = 0; i < 10; i++)
        {
            player.SimulateClick(); // Player의 SimulateClick 메서드 호출
            yield return new WaitForSeconds(0.2f); // 0.2초 대기
        }
    }
}
