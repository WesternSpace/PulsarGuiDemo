using Keen.Game2.Client.UI.Library.Dialogs.ThreeOptionsDialog;
using Keen.VRage.Library.Localization;
using Keen.VRage.Library.Utils;
using System;
namespace PulsarGuiDemo
{
    internal static class Util
    {
        public static LocKey GetKeyFromString(string text)
        {
            return new LocKey()
            {
                TextId = StringId.Get(text)
            };
        }

        public static ThreeOptionsDialogDefinition GetDefaultYesNoCancelDialog()
        {
            return new ThreeOptionsDialogDefinition()
            {
                SelectedOption = ThreeOptionsDialogSelectedOption.Confirm,
                ConfirmOption = GetKeyFromString("Yes"),
                DefaultOption = GetKeyFromString("No"),
                CancelOption = GetKeyFromString("Cancel")
            };
        }
    }
}
