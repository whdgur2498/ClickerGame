using Common.Scene;
using UnityEngine;

public class BasePopup : MonoBehaviour
{
    /// <summary>
    /// 초기화 함수
    /// </summary>
    public virtual void Init()
    {

    }

    /// <summary>
    /// 다음 씬 불러오는 함수
    /// </summary>
    protected void Close(SceneType type)
    {
        SceneManager.LoadScene(type);
    }
}
