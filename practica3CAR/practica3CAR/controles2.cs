using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace practica3CAR
{
    public class controles2 : ContentPage
    {
        public controles2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label{ Text="Pagina 2",
                    FontSize=21,TextColor=Color.Aqua}
                    ,
                    new Picker {Title ="Picker" },
                    new Stepper {BackgroundColor=Color.Aqua},
                    new Switch {BackgroundColor=Color.Blue },
                    new Label{ Text="Profe me  marca error al crear el slider no me ejecuta nada lo borro y si lo ejecuto si de bien",

                        FontSize =21,TextColor=Color.Aqua}
                    
                }
            };
        }
    }
}
