namespace ApplicationName

open System
open Eto.Forms
open Eto.Drawing
open Eto.Serialization.Xaml

type PanelFromXaml () as this =
    inherit Dialog ()

    do
        XamlReader.Load(this, "PanelFromXaml.xeto")

    protected this.DefaultButton_Click(sender: object, e: EventArgs) =
        Close()

    protected this.AbortButton_Click(sender: object, e: EventArgs) =
        Close()