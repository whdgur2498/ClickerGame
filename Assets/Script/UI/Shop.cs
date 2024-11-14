using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public Player player; // Player ������Ʈ ����
    public Text goldText; // Gold ��ȭ���� ǥ���� �ؽ�Ʈ
    private int gold = 1000; // �ʱ� Gold ��ȭ��

    void Start()
    {
        goldText = GameObject.Find("GoldCount").GetComponent<Text>();
        UpdateGoldText(); // �ʱ� Gold ��ȭ�� ǥ��
    }

    void UpdateGoldText()
    {
        goldText.text = gold.ToString(); // Gold ��ȭ�� ������Ʈ
    }

    public void OnAutoClickButton()
    {
        if (gold >= 100)
        {
            gold -= 100; // Gold ��ȭ���� 100 ����
            UpdateGoldText(); // Gold ��ȭ�� ������Ʈ
            StartCoroutine(AutoClickCoroutine()); // Coroutine ����
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
            player.SimulateClick(); // Player�� SimulateClick �޼��� ȣ��
            yield return new WaitForSeconds(0.2f); // 0.2�� ���
        }
    }
}
