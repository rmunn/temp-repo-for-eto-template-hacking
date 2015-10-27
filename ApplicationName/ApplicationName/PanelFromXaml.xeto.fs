namespace ApplicationName

open System
open Eto.Forms
open Eto.Drawing
open Eto.Serialization.Xaml

type PanelFromXaml () as this =
    inherit Drawable ()

    do
        XamlReader.Load(this, "PanelFromXaml.xeto")

    override base.OnPaint(e: PaintEventArgs) =
        // your custom drawing
        e.Graphics.FillRectangle(Colors.Blue, e.ClipRectangle)