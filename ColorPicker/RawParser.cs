using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Drawing;

namespace ColorPicker
{
    class RawParser
    {
        public static List<RawToken> SplitRawText(string rawFile)
        {
            List<RawToken> tokenList = new List<RawToken>();

            foreach (Match m in Regex.Matches(rawFile, @"\[([^]]*)\]", RegexOptions.Multiline))
            {
                tokenList.Add(new RawToken(m.Groups[1].Value));
            }

            return tokenList;
        }

        public static List<ColorDescriptor> ParseColorDescriptorRaws(List<RawToken> tokenList)
        {
            List<ColorDescriptor> colorList = new List<ColorDescriptor>();

            ColorDescriptor tempColor = new ColorDescriptor();

            if (tokenList[0].Token != "OBJECT" || tokenList[0][0] != "DESCRIPTOR_COLOR")
                throw new FormatException("Not a color descriptor raw.");

            foreach (var token in tokenList)
            {
                switch (token.Token)
                {
                    case "COLOR":
                        tempColor = new ColorDescriptor();
                        tempColor.Token = token[0];
                        colorList.Add(tempColor);
                        break;
                    case "NAME":
                        tempColor.Name = token[0];
                        break;
                    case "RGB":
                        tempColor.RGB = Color.FromArgb(byte.Parse(token[0]), byte.Parse(token[1]), byte.Parse(token[2]));
                        break;
                    default:
                        break;
                }
            }
            return colorList;
        }
    }
}
