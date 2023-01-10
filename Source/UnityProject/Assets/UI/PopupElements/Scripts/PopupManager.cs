using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Popups
{
    public class PopupManager : MonoBehaviour, ICallback
    {
        [SerializeField]
        private PopupHolder[] allPopups;

        private Dictionary<PopupName, Popup> activePopups = new();

        private void OnEnable()
        {
            foreach(var popupHolder in allPopups)
            {
                popupHolder.popup.gameObject.SetActive(false);  
            }
        }

        [Title("Methods")]
        [Button]
        public void ShowPopup(PopupName name, object args = null)
        {
            if (this.IsPopupActive(name))
            {
                return;
            }

            var popup= this.FindPopup(name);
            popup.gameObject.SetActive(true);
            popup.Show(args);
            this.activePopups.Add(name, popup);
        }

        [Button]
        public void HidePopup(PopupName name)
        {
            if (!this.IsPopupActive(name))
            {
                return;
            }
            var popup = this.FindPopup(name);
            popup.gameObject.SetActive(false);
            popup.Hide();
            this.activePopups.Remove(name);
        }

        private bool IsPopupActive(PopupName name)
        {
            return this.activePopups.ContainsKey(name);
        }

        private PopupName FindName(Popup popup)
        {
            foreach(var holder in allPopups)
            {
                if(ReferenceEquals(holder.popup, popup))
                {
                    return holder.name;
                }
            }

            throw new Exception($"Popup with {popup.name} wasn't found in Popups pool.");
        }

        private Popup FindPopup(PopupName name)
        {
            foreach (var holder in allPopups)
            {
                if (holder.name == name)
                {
                    return holder.popup;
                }
            }

            throw new Exception($"Popup with name {name.ToString()} wasn't found in Popups pool.");
        }

        void ICallback.OnClose(Popup popup)
        {
            var name = this.FindName(popup);
            this.HidePopup(name); 
        }
    }
}
