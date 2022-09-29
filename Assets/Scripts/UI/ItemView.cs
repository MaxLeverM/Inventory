using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private Image itemIcon;
        [SerializeField] private Image bottomBar;
        [SerializeField] private TMP_Text leftUpperText;
        [SerializeField] private TMP_Text rightUpperText;
        [SerializeField] private TMP_Text leftBottomText;
        [SerializeField] private TMP_Text rightBottomText;
    }
}