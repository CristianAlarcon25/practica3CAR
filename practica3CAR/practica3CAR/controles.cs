using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace practica3CAR
{
    public class controles : ContentPage
    {
        public controles()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label {
                     HorizontalTextAlignment = TextAlignment.Center,
                     Text = "Estos son mis controles!",
                     FontSize =20
                     },
                     new Button {
                     Text ="Mi boton",
                     BorderRadius=12,
                     BackgroundColor=Color.Teal,
                     BorderColor=Color.Navy,
                     BorderWidth=5
                     },
                     new ProgressBar {
                         Progress = 0.3
                     },
                     new DatePicker {BackgroundColor=Color.Silver},
                     new TimePicker
                     {BackgroundColor =Color.Gray},
                     new Entry {
                     FontSize=14,
                     Text="Un Entry"},
                     new ListView {
                         BackgroundColor =Color.Transparent,
                     MinimumWidthRequest=11,
                     Scale=0.9,
                     HeightRequest=90,
                     ItemsSource = new string[]{
                         "ListView",
                         "Android",
                         "IOS",
                         "UWP" },
        },
          new Frame
          {
              BackgroundColor=Color.Gray
              
          },
          new Editor {Text="Edita aqui ,                                                      El de abajo es un BoxView" ,FontSize=12,TextColor=Color.Fuschia},

          new BoxView { Color=Color.Black,WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand},

        }
            };
        }
    }
}
