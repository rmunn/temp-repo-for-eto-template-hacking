﻿namespace ApplicationName

open System
open Eto.Forms
open Eto.Drawing
open Eto.Serialization.Json

type PanelFromJson () as this =
    inherit Form ()

    do
        JsonReader.Load(this, "PanelFromJson.jeto")