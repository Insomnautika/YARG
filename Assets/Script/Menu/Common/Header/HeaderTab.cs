using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using YARG.Menu.Navigation;

namespace YARG.Menu
{
    public class HeaderTab : NavigatableBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Space]
        [SerializeField]
        private TextMeshProUGUI _displayName;
        [SerializeField]
        private Image _sprite;
        [SerializeField]
        private Image _buttonBackground;
        [SerializeField]
        private Color _buttonHoveredColor;

        public string Id { get; private set; }

        public void Init(string id, string displayName, Sprite sprite)
        {
            Id = id;

            _displayName.text = displayName;
            _sprite.sprite = sprite;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _buttonBackground.color = _buttonHoveredColor;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _buttonBackground.color = Color.clear;
        }
    }
}