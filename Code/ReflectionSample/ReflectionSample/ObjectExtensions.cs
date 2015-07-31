using System;
using System.Collections.Generic;
using System.Reflection;

namespace ReflectionSample
{
    // Classes implementing extension methods must be declared
    // as static classes. 
    public static class ObjectExtensions
    {
        // Extension methods always must be declared as static.
        // 'this' referes to object instance extension method will be called upon.
        public static IEnumerable<string> GetPropertyNames(this object obj)
        {
            List<string> propertyNames = new List<string>();

            // We get instance of Type class that describes everything about
            // the class X of an object.
            Type type = obj.GetType();

            // Now we're getting information about all the properties 
            // that class X has.
            PropertyInfo[] properties = type.GetProperties();

            // And we iterate over those properties, one by one.
            foreach (PropertyInfo property in properties)
            {
                string propertyName;

                // We check whether the property is annotated with our 
                // TranslationAttribute.
                TranslationAttribute attr = property.GetCustomAttribute<TranslationAttribute>();
                if (attr != null) // If there is attribute...
                {
                    propertyName = attr.Text; // ... use value stored in it.
                }
                else // ... else if not...
                {
                    propertyName = property.Name; // ... use property name value.
                }
                propertyNames.Add(propertyName);
            }
            return propertyNames;
        }
    }
}
