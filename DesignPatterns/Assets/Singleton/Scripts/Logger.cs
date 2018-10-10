using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger
{
    // Private static refference to instance of this class
    private static Logger _instance;

    // Create an instance of this class only on first use
    public static Logger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
    }

    // Example logging method
    public void Log(string log)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");
        Debug.Log(date + ": " + log);
    }

    // Private constructor to prevent from creating new instances from outside this class
    private Logger()
    {
        
    }
}
