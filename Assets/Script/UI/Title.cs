using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : BasePopup
{
    public override void Init()
    {
        base.Init();
    }

    public void OnClickStartBtn()
    {
        Close(SceneType.InGame);
    }

}
