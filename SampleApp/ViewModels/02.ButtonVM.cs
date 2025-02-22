﻿using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SampleApp.ViewModels;

internal partial class ButtonVM : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<PropertyDescribe> describes =
        new()
        {
            new PropertyDescribe(
                "Text",
                "string",
                "defines the text displayed as the content of the button."
            ),
            new PropertyDescribe(
                "Icon",
                "IconKind",
                "specifies a icon to display as the content of the button."
            ),
            new PropertyDescribe(
                "IconSource",
                "SkPicture",
                "specifies a svg to display as the content of the button."
            ),
            new PropertyDescribe(
                "BackgroundColour",
                "Color",
                "defines the color of the button's background."
            ),
            new PropertyDescribe(
                "ForegroundColor",
                "Color",
                "defines the color of the button's foreground."
            ),
            new PropertyDescribe(
                "FontFamily",
                "string",
                "defines the font family of the button's text."
            ),
            new PropertyDescribe(
                "FontSize",
                "float",
                "defines the font size of the button's text."
            ),
            new PropertyDescribe(
                "FontWeight",
                "int",
                "defines the font weight of the button's text."
            ),
            new PropertyDescribe(
                "FontItalic",
                "bool",
                "defines the font of the button's text is italic."
            ),
            new PropertyDescribe(
                "Shape",
                "Shape",
                "defines the corner radius of the button's border."
            ),
            new PropertyDescribe("Elevation", "int", "defines the elevation height of the button."),
            new PropertyDescribe(
                "OutlineWidth",
                "int",
                "defines the width of the button's border."
            ),
            new PropertyDescribe(
                "OutlineColor",
                "Color",
                "defines the color of the button's border."
            ),
            new PropertyDescribe(
                "RippleColor",
                "Color",
                "defines the color of the button's ripple effect."
            ),
            new PropertyDescribe(
                "Command",
                "ICommand",
                "defines the command that's executed when the button is clicked."
            ),
            new PropertyDescribe(
                "CommandParameter",
                "object",
                "is the parameter that's passed to Command."
            ),
        };
}
