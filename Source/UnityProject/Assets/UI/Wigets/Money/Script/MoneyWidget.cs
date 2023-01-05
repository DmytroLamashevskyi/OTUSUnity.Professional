using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Widget.Money
{
    public class MoneyWidget : MonoBehaviour
    {
        [SerializeField]
        private Sprite sprite;

        [SerializeField]
        private Image icon;
        [SerializeField]
        private Text text;

        private void OnEnable()
        {
            icon.sprite = sprite;
        }

        public void Setup(string value)
        {
            text.text = value; 
        }

        public void UpdateMoney(string value)
        {
            text.text = value;
            this.AnimateTextBounce();
        }

        private void AnimateTextBounce()
        {
            DOTween.Sequence()
                .Append(this.text.gameObject.transform.DOScale(new Vector3(1.1f, 1.1f, 1.1f), 0.1f))
                .Append(this.text.gameObject.transform.DOScale(new Vector3(1.0f, 1.0f, 1.0f), 0.3f));
        }
    }
}
