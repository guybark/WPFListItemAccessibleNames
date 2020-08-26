# WPFListItemAccessibleNames
This is a tiny WPF demo app showing one approach to setting accessible names on items in a ListBox.

The app creates a simple ListBox in XAML, and uses binding to populate the items. By default the UI Automation (UIA) Name properties of the items is some string containing namespace and class names, and that's meaningless to customers when it gets announced by screen readers. The figure below shows the Accessibility Insights for Windows reporting the default UIA Name properties in this demo app.

![Alt text](WPFListItemAccessibleNames/Assets/AIWinBefore.png?raw=true "The AIWin tool reporting the default UIA Name properties of items in a list.")

By providing a converter which generates a helpful and unique AutomationProperties.Name property for each item, that will get announced by a screen reader, and so customers can complete their task as required at the UI. This demo app uses a MultiBinding, but the binding performed with simpler items might not require use of the MultiBinding.

Important: Do not simply set the UIA Name property for an item by overriding the item's ToString(). While that might seem to have the desired effect, it breaks MVVM by putting View information in the Model. It would also not be possible if the app had another view of the item class, or if the item class class wasn't owned by the app.

The figure below shows the Accessibility Insights for Windows reporting the updated UIA Name properties in this demo app.

![Alt text](WPFListItemAccessibleNames/Assets/AIWinAfter.png?raw=true "The AIWin tool reporting the updated UIA Name properties of items in a list.")

