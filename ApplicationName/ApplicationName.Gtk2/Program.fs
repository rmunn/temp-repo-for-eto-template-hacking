namespace ApplicationName.Gtk2
module Program =

    open System
    open ApplicationName

    [<EntryPoint>]
    [<STAThread>]
    let Main(args) = 
        let app = new Eto.Forms.Application(Eto.Platforms.Gtk2)
        app.Run(new MainForm())
        0