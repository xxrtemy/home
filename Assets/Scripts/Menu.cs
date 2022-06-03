using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] Button Button;


    void Start()
    {
        Button.onClick.AddListener(OnButtonClick);
    }


    void Update()
    {
        
    }
    void OnButtonClick()
    {

        SceneLoader.LoadScene(1);
    }
}
