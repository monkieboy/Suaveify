namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Suaveify")>]
[<assembly: AssemblyProductAttribute("Suaveify")>]
[<assembly: AssemblyDescriptionAttribute("Suave Based project")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
