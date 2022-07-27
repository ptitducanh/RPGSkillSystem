using System;
using System.Linq;
using System.Reflection;

public class Utilities
{
    public static Type[] GetAllSubClasses<T>()
    {
        return Assembly.GetAssembly(typeof(T)).GetTypes()
            .Where(myType => myType.IsClass && myType.IsSubclassOf(typeof(T))).ToArray();
    }
}
