using UnityEngine;

namespace GTModTemplate.Utilities;

/// <summary>
/// Utilities for working with methods
/// </summary>
public static class MethodUtilities
{
    /// <summary>
    /// Returns true if the provided Action caused no errors in execution.
    /// </summary>
    public static bool Attempt(Action method)
    {
        try
        {
            method();
        }
        catch (Exception ex)
        {
            Debug.LogError(ex);
            return false;
        }

        return true;
    }

    /// <summary>
    /// Returns true if the provided Func caused no errors in execution, and get it's arguments.
    /// </summary>
    public static bool Attempt(Func method, out object[] args)
    {
        try
        {
            args = new object[] { method() };
        }
        catch (Exception ex)
        {
            Debug.LogError(ex);
            return false;
        }

        return true;
    }

    /// <summary>
    /// Returns true if the provided Func caused no errors in execution.
    /// </summary>
    public static bool Attempt(Func method) => Attempt(method, out var _);
}