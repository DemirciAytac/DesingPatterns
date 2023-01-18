using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodOne.ParameterizedFactoryMethod
{
    public static class ParserFactory
    {
        public static IFileParser Create(string filename)
        {
            var extension = Path.GetExtension(filename);
            return GetParser(extension);
        }

        private static IFileParser GetParser(string extension) 
        {

            switch (extension)
            {
                case ".json": 
                    return new JsonParser();
                    break;
                case ".xml":
                    return new JsonParser();
                    break;
                case ".yaml":
                    return new JsonParser();
                    break;
                default:
                    return new JsonParser();
            }

        }
    }
    public interface IFileParser { }
    public class JsonParser : IFileParser { }
    public class XmlParser : IFileParser { };
    public class YamlParser : IFileParser { };

}
