using System;

using AppKit;
using static NATOPhoneticAlphabet.NATOPhoneticAlphabet;

namespace CocoaAppExample1
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();            
        }

        public void WriteTextToOutput()
        {
            // Just copy the input text to the output.
            // In a real application you would do something,
            // far more complicated here.
            OutputText.StringValue = SpellText(InputText.StringValue);
        }

        partial void CreateOutputAction(Foundation.NSObject sender)
        {
            WriteTextToOutput();
        }


    }
}
