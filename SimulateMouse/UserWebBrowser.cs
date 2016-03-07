using System;
using System.Collections.Generic;
using System.Text;

namespace SimulateMouse
{
    public class UserWebBrowser : System.Windows.Forms.WebBrowser
    {
        private SHDocVw.IWebBrowser2 Iwb2;

        protected override void AttachInterfaces(object nativeActiveXObject)
        {
            Iwb2 = (SHDocVw.IWebBrowser2)nativeActiveXObject;
            Iwb2.Silent = true;
            base.AttachInterfaces(nativeActiveXObject);
        }

        protected override void DetachInterfaces()
        {
            Iwb2 = null;
            base.DetachInterfaces();
        }
    } 
}
