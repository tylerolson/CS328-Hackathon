using UnityEngine;
using UnityEngine.UIElements;

public class HUDController : MonoBehaviour
{
    public GameManager gameManager;
    private Label playerScore;
    private Label aiScore;

    void OnEnable()
    {
        VisualElement root = gameObject.GetComponent<UIDocument>().rootVisualElement;
        playerScore = root.Q<Label>("PlayerScore");
        playerScore.dataSource = gameManager;
        
        playerScore = root.Q<Label>("AIScore");
        playerScore.dataSource = gameManager;
    }


}
