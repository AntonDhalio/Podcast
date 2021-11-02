using System;
using System.Collections.Generic;
using System.Text;


namespace WinForm

{
    public class KategoriValidering
    {
        public KategoriValidering(string input)
        {
            if (string.IsNullOrEmpty(input))
            {

                throw new EmptyInputException();

            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-öA-Ö]"))
            {
                throw new NumberSignException();
            }
        }

    }

    public class UppdateraComboBox
    {
        public UppdateraComboBox(int index)
        {
           
            if (index == -1)
            {
                throw new EmptyInputException();
            }
        }
    }
        public class UrlValidering
        {
            public UrlValidering(string url)
            {
                if (string.IsNullOrEmpty(url))
                {
                    throw new EmptyInputException();
                    
                }


                // Kollar om url är en http isf kasta ett exception om att man måste ha https
                Uri uriResult;
                bool result = Uri.TryCreate(url, UriKind.Absolute, out uriResult);

                if (!result)
                {
                    throw new UrlException("Adressen är ingen giltig URL");
                }
                if (uriResult.Scheme == Uri.UriSchemeHttp)
                {
                    throw new UrlException("Adressen måste vara Https");
                }

            }

        }

    
}



