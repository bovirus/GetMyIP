// Copyright (c) Tim Kennedy. All Rights Reserved. Licensed under the MIT License.

namespace GetMyIP.Configuration;

/// <summary>
/// Class for the static Setting property
/// </summary>
/// <typeparam name="T">Class name of user settings</typeparam>
public abstract class ConfigManager<T> where T : ConfigManager<T>, new()
{
    /// <summary>
    /// Detect if the application is running in design mode (e.g., in Visual Studio designer)
    /// </summary>
    private static readonly bool _isDesignMode =
    DesignerProperties.GetIsInDesignMode(new DependencyObject());

    /// <summary>
    /// Gets or sets the singleton instance of the configuration manager.
    /// </summary>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    public static T Setting
    {
        get
        {
            if (field is not null)
            {
                return field;
            }

            // If in design mode, create a new instance of T to avoid issues in the XAML designer.
            if (_isDesignMode)
            {
                field = new T();
                return field;
            }

            throw new InvalidOperationException($"ConfigManager: {typeof(T).Name}.Setting is not initialized.");
        }

        set
        {
            field = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
