using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCAllApps
{
    public class delegateContravariance
    {
        // Contravariant delegate.
        public delegate void DContravariant<in A>(A argument);

        // Methods that match the delegate signature.
        public static void SampleControl(Control control)
        { }
        public static void SampleButton(Button button)
        { }

        public void Test()
        {

            // Instantiating the delegates with the methods.
            DContravariant<Control> dControl = SampleControl;
            DContravariant<Button> dButton = SampleButton;

            // You can assign dControl to dButton
            // because the DContravariant delegate is contravariant.
            dButton = dControl;

            // Invoke the delegate.
            dButton(new Button());
        }
    }
}
