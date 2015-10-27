namespace ApplicationName

open System
open Eto.Forms
open Eto.Drawing

type PanelFromEtoBase () as this =
    inherit Panel ()

    member this.InitializeComponent() =
        this.Content <- new Label(Text = "Some Content")