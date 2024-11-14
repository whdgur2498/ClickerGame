using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindAnyObjectByType<GameManager>();

                if (instance == null)
                {
                    throw new System.Exception("Not GameObject GameManager");
                }
            }
            return instance;
        }
    }

    [SerializeField] private GameObject playerPrefab;
}
