using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public InputActionAsset playerPlayerAction;
    public Animator playerAnimator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public NewMonoBehaviourScript()
    {
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPlayerAction.FindAction("Run").IsPressed()) 
        {
            playerAnimator.SetBool("Run", true);
        }
        else
             playerAnimator.SetBool("Run", false);
        
        
    }
}

     
