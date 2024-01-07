using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using YARG.Menu.Data;
using YARG.Menu.Navigation;

namespace YARG.Menu.Persistent
{
    public class SettingsBackButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
    {
        [SerializeField]
        private Image _settingsBackButtonBackground;

        [SerializeField]
        private Color _settingsBackgroundColor;


        private void OnEnable()
        {
            _settingsBackButtonBackground.color = Color.clear;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _settingsBackButtonBackground.color = _settingsBackgroundColor;

        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _settingsBackButtonBackground.color = Color.clear;

        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _settingsBackButtonBackground.color = Color.grey;
        }
    }

}
