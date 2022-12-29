﻿// Copyright (c) Tim Kennedy. All Rights Reserved. Licensed under the MIT License.

namespace GetMyIP;

/// <summary>
/// A class and methods for reading, updating and saving user settings in a JSON file
/// </summary>
public class UserSettings : SettingsManager<UserSettings>, INotifyPropertyChanged
{
    #region Properties
    public int PrimaryColor
    {
        get => _primaryColor;
        set
        {
            _primaryColor = value;
            OnPropertyChanged();
        }
    }

    public int DarkMode
    {
        get => _darkmode;
        set
        {
            _darkmode = value;
            OnPropertyChanged();
        }
    }

    public bool IncludeDebug
    {
        get => _includeDebug;
        set
        {
            _includeDebug = value;
            OnPropertyChanged();
        }
    }

    public bool IncludeV6
    {
        get => _includev6;
        set
        {
            _includev6 = value;
            OnPropertyChanged();
        }
    }

    public int InitialPage
    {
        get => _initialPage;
        set
        {
            _initialPage = value;
            OnPropertyChanged();
        }
    }

    public bool KeepOnTop
    {
        get => _keepOnTop;
        set
        {
            _keepOnTop = value;
            OnPropertyChanged();
        }
    }

    public string LogFile
    {
        get => _logFile;
        set
        {
            _logFile = value;
            OnPropertyChanged();
        }
    }
    public int MapProvider
    {
        get => _mapProvider;
        set
        {
            _mapProvider = value;
            OnPropertyChanged();
        }
    }

    public string URL
    {
        get => _url;
        set
        {
            _url = value;
            OnPropertyChanged();
        }
    }

    public int UISize
    {
        get => _uiSize;
        set
        {
            _uiSize = value;
            OnPropertyChanged();
        }
    }

    public double WindowHeight
    {
        get
        {
            if (_windowHeight < 100)
            {
                _windowHeight = 100;
            }
            return _windowHeight;
        }
        set => _windowHeight = value;
    }

    public double WindowLeft
    {
        get
        {
            if (_windowLeft < 0)
            {
                _windowLeft = 0;
            }
            return _windowLeft;
        }
        set => _windowLeft = value;
    }

    public double WindowTop
    {
        get
        {
            if (_windowTop < 0)
            {
                _windowTop = 0;
            }
            return _windowTop;
        }
        set => _windowTop = value;
    }

    public double WindowWidth
    {
        get
        {
            if (_windowWidth < 100)
            {
                _windowWidth = 100;
            }
            return _windowWidth;
        }
        set => _windowWidth = value;
    }
    #endregion Properties

    #region Private backing fields with initial values
    private int _darkmode;
    private bool _includeDebug;
    private bool _includev6 = true;
    private int _initialPage;
    private bool _keepOnTop;
    private string _logFile = string.Empty;
    private int _mapProvider = 1;
    private int _primaryColor = 5;
    private int _uiSize = 2;
    private string _url = "http://ip-api.com/json/?fields=status,message,country,continent,regionName,city,zip,lat,lon,timezone,offset,isp,query";
    private double _windowHeight = 575;
    private double _windowLeft = 200;
    private double _windowWidth = 600;
    private double _windowTop = 100;
    #endregion Private backing fields

    #region Handle property change event
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion Handle property change event
}