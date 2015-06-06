namespace Suaveify
module WebParts =
  open Suave
  open Suave.Http.Successful
  open Suave.Http.Applicatives
  open Suave.Http
  open Suave.Types
  open Suaveify

  let webPart = choose [
        path "/" >>= (OK "Home")
        path "/store" >>= (OK "Store")
        path "/store/browse" >>= (OK "Store")
        path "/store/details" >>= (OK "Details")
        path "/hello" >>= Modules.helloWorld
      ]