using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] HealthController HealthController;
    [SerializeField] Image Image;
    [SerializeField] Text Text;

    private float _maxhealth;
    void Start()
    {
        _maxhealth = HealthController.MaxHealthGetter;
        HealthController.HealthChanged += OnHealthChanged;
        OnHealthChanged(HealthController.CurrentHealth);
    } 

     void OnHealthChanged(float health)
    {
        Image.fillAmount = health / _maxhealth;
        Text.text =health.ToString();
    }
}
