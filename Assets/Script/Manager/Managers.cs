using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public sealed class Managers : MonoBehaviour
{
    private static Managers instance;

    public static UIManager UI { get { return instance.uiManager; } }
    public static SoundManager Sound { get { return instance.soundManager; } }

    private UIManager uiManager;
    private SoundManager soundManager;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    //�� �����ں��� ���� �����ϰ� �� �����ֱ⿡�� awake���� �켱 ����
    private static void Init()
    {
        Screen.SetResolution(1920, 1080, false);


        //ó�� ���� scene�� �ε�Ǳ� �� instance�� null�̱� ������ �ش� �ڵ带 ����
        GameObject gameObject = new GameObject("Managers");
        instance = gameObject.AddComponent<Managers>();
        //Managers��� �� ���ӿ��� ����� Managers ������Ʈ�� ����.
        DontDestroyOnLoad(gameObject);

        instance.uiManager = CreateManager<UIManager>(gameObject.transform);
        instance.soundManager = CreateManager<SoundManager>(gameObject.transform);
    }


    /// <summary>
    /// Hierarchyâ�� Manager������ִ� �Լ�
    /// </summary>
    private static T CreateManager<T>(Transform parent) where T : Component, IManager
    {
        GameObject gameObject = new GameObject(typeof(T).Name);
        T generic = gameObject.AddComponent<T>();
        gameObject.transform.parent = parent;

        generic.Init();

        return generic;
    }
}
