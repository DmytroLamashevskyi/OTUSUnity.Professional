using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Popups
{
    public class Popup : MonoBehaviour
    {
        private ICallback callback;

        public void Show(object args=null,ICallback callback = null)
        {
            this.callback = callback;
            this.OnShow(args);
        }

        public void Hide()
        {
            this.OnHide();
        }

        protected virtual void OnShow(object args)
        {

        }

        protected virtual void OnHide()
        {

        }

        public void RequestClose()
        {
            this.callback?.OnClose(this);  
        }
    }

}
