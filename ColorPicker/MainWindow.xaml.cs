﻿using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace ColorPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string defaultColors = @"descriptor_color_standard

[OBJECT:DESCRIPTOR_COLOR]

Most of these are from Wikipedia's color list.

[COLOR:AMBER]
	[NAME:amber]
	[WORD:AMBER]
	[RGB:255:191:0]

[COLOR:AMETHYST]
	[NAME:amethyst]
	[WORD:AMETHYST]
	[RGB:153:102:204]

[COLOR:AQUA]
	[NAME:aqua]
	[WORD:AQUA]
	[RGB:0:255:255]

[COLOR:AQUAMARINE]
	[NAME:aquamarine]
	[WORD:AQUAMARINE]
	[RGB:127:255:212]

[COLOR:ASH_GRAY]
	[NAME:ash gray]
	[WORD:GRAY]
	[RGB:178:190:181]

[COLOR:AUBURN]
	[NAME:auburn]
	[WORD:AUBURN]
	[RGB:111:53:26]

[COLOR:AZURE]
	[NAME:azure]
	[WORD:AZURE]
	[RGB:0:127:255]

[COLOR:BEIGE]
	[NAME:beige]
	[WORD:BEIGE]
	[RGB:245:245:220]

[COLOR:BLACK]
	[NAME:black]
	[WORD:BLACK]
	[RGB:0:0:0]

[COLOR:BLUE]
	[NAME:blue]
	[WORD:BLUE]
	[RGB:0:0:255]

[COLOR:BRASS]
	[NAME:brass]
	[WORD:BRASS]
	[RGB:181:166:66]

[COLOR:BRONZE]
	[NAME:bronze]
	[WORD:BRONZE]
	[RGB:205:127:50]

[COLOR:BROWN]
	[NAME:brown]
	[WORD:BROWN]
	[RGB:150:75:0]

[COLOR:BUFF]
	[NAME:buff]
	[WORD:BUFF]
	[RGB:240:220:130]

[COLOR:BURNT_SIENNA]
	[NAME:burnt sienna]
	[WORD:SIENNA]
	[RGB:233:116:81]

[COLOR:BURNT_UMBER]
	[NAME:burnt umber]
	[WORD:UMBER]
	[RGB:138:51:36]

[COLOR:CARDINAL]
	[NAME:cardinal]
	[WORD:CARDINAL_COLOR]
	[RGB:196:30:58]

[COLOR:CARMINE]
	[NAME:carmine]
	[WORD:CARMINE]
	[RGB:150:0:24]

[COLOR:CERULEAN]
	[NAME:cerulean]
	[WORD:CERULEAN]
	[RGB:0:123:167]

[COLOR:CHARCOAL]
	[NAME:charcoal]
	[WORD:CHARCOAL]
	[RGB:54:69:79]

[COLOR:CHARTREUSE]
	[NAME:chartreuse]
	[WORD:CHARTREUSE]
	[RGB:127:255:0]

[COLOR:CHESTNUT]
	[NAME:chestnut]
	[WORD:CHESTNUT]
	[RGB:205:92:92]

[COLOR:CHOCOLATE]
	[NAME:chocolate]
	[WORD:CHOCOLATE]
	[RGB:210:105:30]

[COLOR:CINNAMON]
	[NAME:cinnamon]
	[WORD:CINNAMON]
	[RGB:123:63:0]

[COLOR:CLEAR]
	[NAME:clear]
	[WORD:CLEAR]
	[RGB:128:128:128]

[COLOR:COBALT]
	[NAME:cobalt]
	[WORD:COBALT]
	[RGB:0:71:171]

[COLOR:COPPER]
	[NAME:copper]
	[WORD:COPPER]
	[RGB:184:115:51]

[COLOR:CREAM]
	[NAME:cream]
	[WORD:CREAM]
	[RGB:255:253:208]

[COLOR:CRIMSON]
	[NAME:crimson]
	[WORD:CRIMSON]
	[RGB:220:20:60]

[COLOR:DARK_BLUE]
	[NAME:dark blue]
	[WORD:BLUE]
	[RGB:0:0:139]

[COLOR:DARK_BROWN]
	[NAME:dark brown]
	[WORD:BROWN]
	[RGB:101:67:33]

[COLOR:DARK_CHESTNUT]
	[NAME:dark chestnut]
	[WORD:CHESTNUT]
	[RGB:152:105:96]

[COLOR:DARK_GREEN]
	[NAME:dark green]
	[WORD:GREEN]
	[RGB:1:50:32]

[COLOR:DARK_INDIGO]
	[NAME:dark indigo]
	[WORD:INDIGO]
	[RGB:49:0:98]

[COLOR:DARK_OLIVE]
	[NAME:dark olive]
	[WORD:OLIVE]
	[RGB:85:104:50]

[COLOR:DARK_PEACH]
	[NAME:dark peach]
	[WORD:PEACH]
	[RGB:255:218:185]

[COLOR:DARK_PINK]
	[NAME:dark pink]
	[WORD:PINK]
	[RGB:231:84:128]

[COLOR:DARK_SCARLET]
	[NAME:dark scarlet]
	[WORD:SCARLET]
	[RGB:86:3:25]

[COLOR:DARK_TAN]
	[NAME:dark tan]
	[WORD:TAN]
	[RGB:145:129:81]

[COLOR:DARK_VIOLET]
	[NAME:dark violet]
	[WORD:VIOLET]
	[RGB:66:49:137]

[COLOR:ECRU]
	[NAME:ecru]
	[WORD:ECRU]
	[RGB:194:178:128]

[COLOR:EGGPLANT]
	[NAME:eggplant]
	[RGB:97:64:81]

[COLOR:EMERALD]
	[NAME:emerald]
	[WORD:EMERALD]
	[RGB:80:200:120]

[COLOR:FERN_GREEN]
	[NAME:fern green]
	[WORD:GREEN]
	[RGB:79:121:66]

[COLOR:FLAX]
	[NAME:flax]
	[WORD:FLAX]
	[RGB:238:220:130]

[COLOR:FUCHSIA]
	[NAME:fuchsia]
	[WORD:FUCHSIA]
	[RGB:244:0:161]

[COLOR:GOLD]
	[NAME:gold]
	[WORD:GOLD]
	[RGB:212:175:55]

[COLOR:GOLDEN_YELLOW]
	[NAME:golden yellow]
	[WORD:GOLD]
	[WORD:YELLOW]
	[RGB:255:223:0]

[COLOR:GOLDENROD]
	[NAME:goldenrod]
	[WORD:GOLDENROD]
	[RGB:218:165:32]

[COLOR:GRAY]
	[NAME:gray]
	[WORD:GRAY]
	[RGB:128:128:128]

[COLOR:GREEN]
	[NAME:green]
	[WORD:GREEN]
	[RGB:0:255:0]

[COLOR:GREEN-YELLOW]
	[NAME:green-yellow]
	[WORD:GREEN]
	[WORD:YELLOW]
	[RGB:173:255:47]

[COLOR:HELIOTROPE]
	[NAME:heliotrope]
	[WORD:HELIOTROPE]
	[RGB:223:115:255]

[COLOR:INDIGO]
	[NAME:indigo]
	[WORD:INDIGO]
	[RGB:75:0:130]

[COLOR:IVORY]
	[NAME:ivory]
	[WORD:IVORY]
	[RGB:255:255:240]

[COLOR:JADE]
	[NAME:jade]
	[WORD:JADE]
	[RGB:0:168:107]

[COLOR:LAVENDER]
	[NAME:lavender]
	[WORD:LAVENDER]
	[RGB:230:230:250]

[COLOR:LAVENDER_BLUSH]
	[NAME:lavender blush]
	[WORD:LAVENDER]
	[RGB:255:240:245]

[COLOR:LEMON]
	[NAME:lemon]
	[WORD:LEMON]
	[RGB:253:233:16]

[COLOR:LIGHT_BLUE]
	[NAME:light blue]
	[WORD:BLUE]
	[RGB:173:216:230]

[COLOR:LIGHT_BROWN]
	[NAME:light brown]
	[WORD:BROWN]
	[RGB:205:133:63]

[COLOR:LILAC]
	[NAME:lilac]
	[WORD:LILAC]
	[RGB:200:162:200]

[COLOR:LIME]
	[NAME:lime]
	[WORD:LIME]
	[RGB:204:255:0]

[COLOR:MAHOGANY]
	[NAME:mahogany]
	[WORD:MAHOGANY]
	[RGB:192:64:0]

[COLOR:MAROON]
	[NAME:maroon]
	[WORD:MAROON_COLOR]
	[RGB:128:0:0]

[COLOR:MAUVE]
	[NAME:mauve]
	[WORD:MAUVE]
	[RGB:153:51:102]

[COLOR:MAUVE_TAUPE]
	[NAME:mauve taupe]
	[WORD:MAUVE]
	[WORD:TAUPE]
	[RGB:145:95:109]

[COLOR:MIDNIGHT_BLUE]
	[NAME:midnight blue]
	[WORD:BLUE]
	[RGB:0:51:102]

[COLOR:MINT_GREEN]
	[NAME:mint green]
	[WORD:GREEN]
	[RGB:152:255:152]

[COLOR:MOSS_GREEN]
	[NAME:moss green]
	[WORD:GREEN]
	[RGB:173:223:173]

[COLOR:OCHRE]
	[NAME:ochre]
	[WORD:OCHRE]
	[RGB:204:119:34]

[COLOR:OLIVE]
	[NAME:olive]
	[WORD:OLIVE]
	[RGB:128:128:0]

[COLOR:ORANGE]
	[NAME:orange]
	[WORD:ORANGE]
	[RGB:255:165:0]

[COLOR:PALE_BLUE]
	[NAME:pale blue]
	[WORD:BLUE]
	[RGB:175:238:238]

[COLOR:PALE_BROWN]
	[NAME:pale brown]
	[WORD:BROWN]
	[RGB:152:118:84]

[COLOR:PALE_CHESTNUT]
	[NAME:pale chestnut]
	[WORD:CHESTNUT]
	[RGB:221:173:175]

[COLOR:PALE_PINK]
	[NAME:pale pink]
	[WORD:PINK]
	[RGB:250:218:221]

[COLOR:PEACH]
	[NAME:peach]
	[WORD:PEACH]
	[RGB:255:229:180]

[COLOR:PEARL]
	[NAME:pearl]
	[WORD:PEARL]
	[RGB:240:234:214]

[COLOR:PERIWINKLE]
	[NAME:periwinkle]
	[WORD:PERIWINKLE]
	[RGB:204:204:255]

[COLOR:PINE_GREEN]
	[NAME:pine green]
	[WORD:GREEN]
	[WORD:PINE]
	[RGB:1:121:111]

[COLOR:PINK]
	[NAME:pink]
	[WORD:PINK]
	[RGB:255:192:203]

[COLOR:PLUM]
	[NAME:plum]
	[WORD:PLUM]
	[RGB:102:0:102]

[COLOR:PUCE]
	[NAME:puce]
	[WORD:PUCE]
	[RGB:204:136:153]

[COLOR:PUMPKIN]
	[NAME:pumpkin]
	[WORD:PUMPKIN]
	[RGB:255:117:24]

[COLOR:PURPLE]
	[NAME:purple]
	[WORD:PURPLE]
	[RGB:102:0:153]

[COLOR:RAW_UMBER]
	[NAME:raw umber]
	[WORD:UMBER]
	[RGB:115:74:18]

[COLOR:RED]
	[NAME:red]
	[WORD:RED]
	[RGB:255:0:0]

[COLOR:RED_PURPLE]
	[NAME:red-purple]
	[WORD:RED]
	[WORD:PURPLE]
	[RGB:178:0:75]

[COLOR:ROSE]
	[NAME:rose]
	[WORD:ROSE]
	[RGB:244:194:194] went with tea rose

[COLOR:RUSSET]
	[NAME:russet]
	[WORD:RUSSET]
	[RGB:117:90:87]

[COLOR:RUST]
	[NAME:rust]
	[WORD:RUST]
	[RGB:183:65:14]

[COLOR:SAFFRON]
	[NAME:saffron]
	[WORD:SAFFRON]
	[RGB:244:196:48]

[COLOR:SCARLET]
	[NAME:scarlet]
	[WORD:SCARLET]
	[RGB:255:36:0]

[COLOR:SEA_GREEN]
	[NAME:sea green]
	[WORD:GREEN]
	[WORD:SEA]
	[WORD:OCEAN]
	[RGB:46:139:87]

[COLOR:SEPIA]
	[NAME:sepia]
	[WORD:SEPIA]
	[RGB:112:66:20]

[COLOR:SILVER]
	[NAME:silver]
	[WORD:SILVER]
	[RGB:192:192:192]

[COLOR:SKY_BLUE]
	[NAME:sky blue]
	[WORD:BLUE]
	[RGB:135:206:235]

[COLOR:SLATE_GRAY]
	[NAME:slate gray]
	[WORD:GRAY]
	[RGB:112:128:144]

[COLOR:SPRING_GREEN]
	[NAME:spring green]
	[WORD:GREEN]
	[RGB:0:255:127]

[COLOR:TAN]
	[NAME:tan]
	[WORD:TAN]
	[RGB:210:180:140]

[COLOR:TAUPE_DARK]
	[NAME:dark taupe]
	[WORD:TAUPE]
	[RGB:72:60:50]

[COLOR:TAUPE_GRAY]
	[NAME:taupe gray]
	[WORD:TAUPE]
	[WORD:GRAY]
	[RGB:139:133:137]

[COLOR:TAUPE_MEDIUM]
	[NAME:taupe]
	[WORD:TAUPE]
	[RGB:103:76:71]

[COLOR:TAUPE_PURPLE]
	[NAME:purple taupe]
	[WORD:PURPLE]
	[WORD:TAUPE]
	[RGB:80:64:77]

[COLOR:TAUPE_PALE]
	[NAME:pale taupe]
	[WORD:TAUPE]
	[RGB:188:152:126]

[COLOR:TAUPE_ROSE]
	[NAME:rose taupe]
	[WORD:TAUPE]
	[RGB:144:93:93]

[COLOR:TAUPE_SANDY]
	[NAME:sandy taupe]
	[WORD:TAUPE]
	[RGB:150:113:23]

[COLOR:TEAL]
	[NAME:teal]
	[WORD:TEAL]
	[RGB:0:128:128]

[COLOR:TURQUOISE]
	[NAME:turquoise]
	[WORD:TURQUOISE]
	[RGB:48:213:200]

[COLOR:VERMILION]
	[NAME:vermilion]
	[WORD:VERMILION]
	[RGB:227:66:52]

[COLOR:VIOLET]
	[NAME:violet]
	[WORD:VIOLET]
	[RGB:139:0:255]

[COLOR:WHITE]
	[NAME:white]
	[WORD:WHITE]
	[RGB:255:255:255]

[COLOR:YELLOW]
	[NAME:yellow]
	[WORD:YELLOW]
	[RGB:255:255:0]

[COLOR:YELLOW_GREEN]
	[NAME:yellow-green]
	[WORD:GREEN]
	[WORD:YELLOW]
	[RGB:154:205:50]";

            var colorList = RawParser.ParseColorDescriptorRaws(RawParser.SplitRawText(defaultColors));
            colorList.Sort();
            lbColorList.ItemsSource = colorList;
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "descriptor_color_standard.txt|descriptor_color_standard.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                var fileContents = File.ReadAllText(openFileDialog.FileName);
                var colorList = RawParser.ParseColorDescriptorRaws(RawParser.SplitRawText(fileContents));
                colorList.Sort();
                lbColorList.ItemsSource = colorList;
            }
        }

        private void LbColorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string outputString = "";
            var listbox = (ListBox)sender;
            foreach (ColorDescriptor color in listbox.SelectedItems)
            {
                outputString += ":" + color.Token + ":1";
            }
            outputBox.Text = outputString;
        }

        private void PasteButton_Click(object sender, RoutedEventArgs e)
        {
            string colors = Clipboard.GetText();
            lbColorList.SelectedItems.Clear();
            List<ColorDescriptor> colorList = (List<ColorDescriptor>)lbColorList.ItemsSource;
            foreach (var item in colors.Split(':'))
            {
                int index = colorList.FindIndex(x => x.Token == item);
                if (index >= 0)
                    lbColorList.SelectedItems.Add(colorList[index]);
            }
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(outputBox.Text);
        }
    }
}
