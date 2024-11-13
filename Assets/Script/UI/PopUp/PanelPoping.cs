using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPoping : MonoBehaviour
{
    public GameObject animatorObject; // Animator가 추가된 오브젝트를 참조
    private Animator animator;
    private bool isShown = false;

    void Start()
    {
        if (animatorObject != null)
        {
            animator = animatorObject.GetComponent<Animator>();
        }
        else
        {
            Debug.LogError("Animator Object is not assigned.");
        }
    }

    public void OnClickButton()
    {
        if (animator != null)
        {
            if (isShown)
            {
                animator.SetTrigger("doHide");
            }
            else
            {
                animator.SetTrigger("doShow");
            }

            isShown = !isShown;
        }
        else
        {
            Debug.LogError("Animator component is missing.");
        }
    }
}
