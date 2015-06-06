open Suave                 // always open suave
open Suave.Http.Successful // for OK-result
open Suave.Web             // for config
open Suaveify

startWebServer defaultConfig WebParts.webPart