namespace ApplicationName

open System
open Eto.Forms
open Eto.Drawing
open Eto.Serialization.Xaml

type PanelFromXaml () as this =
    inherit Scrollable ()

    do
        XamlReader.Load(this, "PanelFromXaml.xeto")