namespace Tests

module SuaveifyTests =
    open Suave.Http.Successful
    open Suaveify
    open NUnit.Framework

    [<Test>]
    let ``Hello World`` () =
        let expected = (OK "Hello World!")
        let actual = Modules.helloWorld
        Assert.AreEqual(expected, actual)