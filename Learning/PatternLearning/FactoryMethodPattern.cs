using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLearning
{
    class FactoryMethodPattern
    {
        public interface ICardField
        {
            string Operation(string fieldValue);
        }
        class Phone : ICardField
        {
            public string Operation(string fieldValue)
            {
                return $"<a href=”tel:{fieldValue}”>{fieldValue}</a>";
            }
        }

        class Href : ICardField
        {
            public string Operation(string fieldValue)
            {
                return $"<a href={fieldValue}”>{fieldValue}</a>";
            }
        }
        class TextField : ICardField
        {
            public string Operation(string fieldValue)
            {
                return fieldValue;
            }
        }

        public abstract class Creator
        {
            private string htmlString;
            public Creator(string _htmlString) {
                htmlString = _htmlString;
            }
            protected abstract ICardField FactoryMethod();
            public string GetHTMLPrintString()
            {
                var product = FactoryMethod();
                return product.Operation(htmlString);
            }
        }

        public class PhoneCreator : Creator
        {
            public PhoneCreator(string _htmlString) : base(_htmlString)
            {
            }

            protected override ICardField FactoryMethod()
            {
                return new Phone();
            }
        }
        public class HrefCreator : Creator
        {
            public HrefCreator(string _htmlString) : base(_htmlString)
            {
            }

            protected override ICardField FactoryMethod()
            {
                return new Href();
            }
        }
        public class TextFieldCreator : Creator
        {
            public TextFieldCreator(string _htmlString) : base(_htmlString)
            {
            }

            protected override ICardField FactoryMethod()
            {
                return new TextField();
            }
        }
    }
}
