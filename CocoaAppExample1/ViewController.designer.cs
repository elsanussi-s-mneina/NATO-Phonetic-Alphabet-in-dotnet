// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CocoaAppExample1
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField InputText { get; set; }

		[Outlet]
		AppKit.NSTextField OutputText { get; set; }

		[Action ("CreateOutputAction:")]
		partial void CreateOutputAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (InputText != null) {
				InputText.Dispose ();
				InputText = null;
			}

			if (OutputText != null) {
				OutputText.Dispose ();
				OutputText = null;
			}
		}
	}
}
