namespace ApplicationName.WinForms
module Program =

    open System
    open ApplicationName

    [<EntryPoint>]
    [<STAThread>]
    let Main(args) = 
        let app = new Eto.Forms.Application(Eto.Platforms.WinForms)
        app.Run(new MainForm())
        0