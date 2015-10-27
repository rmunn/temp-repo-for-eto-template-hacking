namespace ApplicationName.Gtk3
module Program =

    open System
    open ApplicationName

    [<EntryPoint>]
    [<STAThread>]
    let Main(args) = 
        let app = new Eto.Forms.Application(Eto.Platforms.Gtk3)
        app.Run(new MainForm())
        0