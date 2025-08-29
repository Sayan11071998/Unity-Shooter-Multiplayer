using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public TMP_Text overheatedMessage;
    public Slider weaponTempSlider;

    private void Awake()
    {
        instance = this;
    }
}