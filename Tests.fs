module Tests

open System
open Xunit
open Library.KataProblem

[<Fact>]
let empty_string_test () =
    Assert.Equal("", text_to_morse(""))

[<Fact>]
let one_letter_test () =
    Assert.Equal("....", text_to_morse("H"))

[<Fact>]
let word_test () =
    Assert.Equal(".... . .-.. .-.. ---", text_to_morse("Hello"))

[<Fact>]
let phrase_test () =
    Assert.Equal(".... . .-.. .-.. --- --..-- / .-- --- .-. .-.. -..", text_to_morse("Hello, World"))
