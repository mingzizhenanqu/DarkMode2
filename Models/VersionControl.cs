﻿namespace DarkMode_2.Models;

public class VersionControl
{
    public static string Channel()
    {
        string channel = "Beta";
        return channel;
    }
    public static string Version()
    {
        string version = "2.0.6";
        return version;
    }
    public static string InternalVersion()
    {
        string internalVersion = "20221222";
        return internalVersion;
    }
}
