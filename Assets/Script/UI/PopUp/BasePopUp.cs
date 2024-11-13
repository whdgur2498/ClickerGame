using Common.Scene;
using UnityEngine;

public class BasePopup : MonoBehaviour
{
    /// <summary>
    /// �ʱ�ȭ �Լ�
    /// </summary>
    public virtual void Init()
    {

    }

    /// <summary>
    /// ���� �� �ҷ����� �Լ�
    /// </summary>
    protected void Close(SceneType type)
    {
        SceneManager.LoadScene(type);
    }
}
