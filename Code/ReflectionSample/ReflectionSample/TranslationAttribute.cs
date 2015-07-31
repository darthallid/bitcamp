using System;

namespace ReflectionSample
{
    public class TranslationAttribute : Attribute
    {
        // Property storing translated value.
        // Notice it has private setter indicating it can only be
        // set via class constructor.
        public string Text { get; private set; }

        public TranslationAttribute(string text)
        {
            Text = text;
        }
    }
}
