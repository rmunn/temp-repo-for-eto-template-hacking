namespace ApplicationName

open System
open Eto.Forms
open Eto.Drawing
open Eto.Serialization.Json

type PanelFromJson () as this =
    inherit Dialog ()

    do
        JsonReader.Load(this, "PanelFromJson.jeto")

    protected this.DefaultButton_Click(sender: object, e: EventArgs) =
        Close()

    protected this.AbortButton_Click(sender: object, e: EventArgs) =
        Close()