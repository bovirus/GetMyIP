// Copyright (c) Tim Kennedy. All Rights Reserved. Licensed under the MIT License.

namespace GetMyIP.Views;

/// <summary>
/// External IP and Geolocation information
/// </summary>
public partial class ExternalInfoPage : UserControl
{
    public ExternalInfoPage()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Partially handles the Click event of the Button control. Returns the selected row in the parent DataGrid to the
    /// unselected state. There is also a relay command that handles the copy to clipboard functionality. This is a
    /// workaround necessitated by having a button in a DataGrid row. There may be a better way to do this, but this
    /// works for now.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event data.</param>
    private void CopyButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is not Button button)
        {
            return;
        }
        DataGridRow? row = MainWindowHelpers.FindParent<DataGridRow>(button);
        if (row is null)
        {
            return;
        }
        row.IsSelected = false;
    }
}
