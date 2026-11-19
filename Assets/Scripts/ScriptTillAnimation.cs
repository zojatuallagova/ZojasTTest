using UnityEngine;
using UnityEngine.InputSystem;

public class ScriptTillAnimation : MonoBehaviour
{
    public InputActionAsset ZojasPlayerAction;

    public Animator ZojasAnimator;
   

    // Update is called once per frame
    void Update()
    {
        if(ZojasPlayerAction.FindAction("Move").IsPressed())
        {
            ZojasAnimator.SetBool("Walk", true);
        }
        else
        {
            ZojasAnimator.SetBool("Walk", false);
        }
        
        if(ZojasPlayerAction.FindAction("Jump").IsPressed())
        {
            ZojasAnimator.SetBool("Jump", true);
        }
        else
        {
            ZojasAnimator.SetBool("Jump", false);
        }
    }
}
