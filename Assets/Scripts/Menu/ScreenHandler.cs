using StarterAssets;
using UnityEngine;

public class ScreenHandler : StateHandler
{
    [SerializeField] private string handlerName;
    [SerializeField] private CanvasGroup canvasGroup;
    public override string Name => handlerName;

    private GameObject player;

    public MenuStateMachine stateMachine;

    public override void OnEnter<T>(T transition)
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;

        if (stateMachine.CurrentState == stateMachine.MainMenuHandler)
        {
            Debug.Log("current state main menu");
            Time.timeScale = 0;
            player.GetComponent<StarterAssetsInputs>().cursorLocked = false;
            Cursor.lockState = CursorLockMode.None;
            player.GetComponent<StarterAssetsInputs>().cursorInputForLook = false;
        }
        else if (stateMachine.CurrentState == stateMachine.StartGameHandler)
        {
            Debug.Log("current state play game");
            Time.timeScale = 1;
            player.GetComponent<StarterAssetsInputs>().cursorLocked = true;
            Cursor.lockState = CursorLockMode.Locked;
            player.GetComponent<StarterAssetsInputs>().cursorInputForLook = true;
        }

    }

    public override void OnExit<T>(T transition)
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

    }

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        OnEnter(MenuTransitions.MainMenuSelected);
    }

    public void PlayerDeath()
    {
        OnEnter(MenuTransitions.PlayerDead);
    }
}