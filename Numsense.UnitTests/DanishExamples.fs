﻿module Ploeh.Numsense.DanishExamples

open Xunit
open Swensen.Unquote

[<Theory>]
[<InlineData(                                              "nul",          0)>]
[<InlineData(                                             " nul",          0)>]
[<InlineData(                                             "nul ",          0)>]
[<InlineData(                                          "  nul  ",          0)>]
[<InlineData(                                              "Nul",          0)>]
[<InlineData(                                              "NUL",          0)>]
[<InlineData(                                            "nUl\t",          0)>]
[<InlineData(                                               "et",          1)>]
[<InlineData(                                               "en",          1)>]
[<InlineData(                                               "ET",          1)>]
[<InlineData(                                               "to",          2)>]
[<InlineData(                                              " to",          2)>]
[<InlineData(                                              "tre",          3)>]
[<InlineData(                                            "tre  ",          3)>]
[<InlineData(                                             "fire",          4)>]
[<InlineData(                                          "  fire ",          4)>]
[<InlineData(                                              "fem",          5)>]
[<InlineData(                                              "FeM",          5)>]
[<InlineData(                                             "seks",          6)>]
[<InlineData(                                         "  SEKS  ",          6)>]
[<InlineData(                                              "syv",          7)>]
[<InlineData(                                          "    sYv",          7)>]
[<InlineData(                                             "otte",          8)>]
[<InlineData(                                             "oTTE",          8)>]
[<InlineData(                                               "ni",          9)>]
[<InlineData(                                             "Ni  ",          9)>]
[<InlineData(                                               "ti",         10)>]
[<InlineData(                                           "elleve",         11)>]
[<InlineData(                                             "tolv",         12)>]
[<InlineData(                                          "tretten",         13)>]
[<InlineData(                                          "fjorten",         14)>]
[<InlineData(                                           "femten",         15)>]
[<InlineData(                                          "seksten",         16)>]
[<InlineData(                                           "sytten",         17)>]
[<InlineData(                                            "atten",         18)>]
[<InlineData(                                           "nitten",         19)>]
[<InlineData(                                             "tyve",         20)>]
[<InlineData(                                         "enogtyve",         21)>]
[<InlineData(                                          "tredive",         30)>]
[<InlineData(                                    "fireogtredive",         34)>]
[<InlineData(                                            "fyrre",         40)>]
[<InlineData(                                      "fireogfyrre",         44)>]
[<InlineData(                                        "halvtreds",         50)>]
[<InlineData(                                   "syvoghalvtreds",         57)>]
[<InlineData(                                             "tres",         60)>]
[<InlineData(                                        "femogtres",         65)>]
[<InlineData(                                       "halvfjerds",         70)>]
[<InlineData(                                   "nioghalvfjerds",         79)>]
[<InlineData(                                             "firs",         80)>]
[<InlineData(                                       "seksogfirs",         86)>]
[<InlineData(                                         "halvfems",         90)>]
[<InlineData(                                    "treoghalvfems",         93)>]
[<InlineData(                                         "hundrede",        100)>]
[<InlineData(                                       "ethundrede",        100)>]
[<InlineData(                                       "hundredeet",        101)>]
[<InlineData(                                     "hundredeoget",        101)>]
[<InlineData(                                   "hundrede-og-et",        101)>]
[<InlineData(                                     "ethundredeet",        101)>]
[<InlineData(                                   "ethundredeoget",        101)>]
[<InlineData(                                "et-hundrede-og-et",        101)>]
[<InlineData(                                       "tohundrede",        200)>]
[<InlineData(                           "tohundredesyvogtredive",        237)>]
[<InlineData(                       "trehundredefemoghalvfjerds",        375)>]
[<InlineData(                             "firehundredehalvfems",        490)>]
[<InlineData(                             "femhundredetreogtres",        563)>]
[<InlineData(                                "sekshundredeatten",        618)>]
[<InlineData(                       "syvhundredesyvoghalvfjerds",        777)>]
[<InlineData(                                "ottehundredeogfem",        805)>]
[<InlineData(                               "ottehundredeogseks",        806)>]
[<InlineData(                             "otte-hundrede-og-syv",        807)>]
[<InlineData(                          "nihundredenioghalvtreds",        959)>]
[<InlineData(                                           "tusind",       1000)>]
[<InlineData(                                         "ettusind",       1000)>]
[<InlineData(                                       "tusindogen",       1001)>]
[<InlineData(                                     "ettusindogto",       1002)>]
[<InlineData(                             "ettusindogfireogtres",       1064)>]
[<InlineData(                                         "totusind",       2000)>]
[<InlineData(                  "ottetusindsyvhundredeogenogtyve",       8721)>]
[<InlineData(                "ni-tusind-et-hundrede-tre-og-tyve",       9123)>]
[<InlineData(                                         "titusind",      10000)>]
[<InlineData(                             "titusindethundredeet",      10101)>]
[<InlineData(                      "ti-tusind-et-hundrede-og-to",      10102)>]
[<InlineData(             "treogtyvetusindfemhundredefireogtres",      23564)>]
[<InlineData(                                   "firstusindogti",      80010)>]
[<InlineData(                                   "hundredetusind",     100000)>]
[<InlineData(                                 "ethundredetusind",     100000)>]
[<InlineData(                             "ethundredetusindoget",     100001)>]
[<InlineData(      "trehundredenittentusindtrehundredeniogfyrre",     319349)>]
[<InlineData(                                        "enmillion",    1000000)>]
[<InlineData(                                      "enmillionen",    1000001)>]
[<InlineData(                                    "tomillionerti",    2000010)>]
[<InlineData(                     "seksmillionerogtredivetusind",    6030000)>]
[<InlineData(    "nimillionertohundredeettusindsekshundredefirs",    9201680)>]
[<InlineData(                                      "timillioner",   10000000)>]
[<InlineData(                                  "timillionerogni",   10000009)>]
[<InlineData(                               "enogtyve millioner",   21000000)>]
[<InlineData("syvogfyrremillionersekshundredeenogtrestusindtres",   47661060)>]
[<InlineData(                               "hundrede millioner",  100000000)>]
[<InlineData(                              "ethundredemillioner",  100000000)>]
[<InlineData(                           "tohundredefemmillioner",  205000000)>]
[<InlineData(                    "tre-hundrede-og-syv-millioner",  307000000)>]
[<InlineData("firehundredeenogtresmillionertrestusindtohundrede",  461060200)>]
[<InlineData(                                       "enmilliard", 1000000000)>]
[<InlineData(                                    "to milliarder", 2000000000)>]
[<InlineData("tomilliarderniogtyvemillionertohundredetrestusind", 2029260000)>]
[<InlineData(
    "tomilliarderethundredesyvogfyrremillionerfirehundredetreogfirstusindsekshundredesyvogfyrre",
    System.Int32.MaxValue)>]
let ``tryOfDanish returns correct result`` (danish, expected) =
    let actual = Numeral.tryParseDanish danish
    Some expected =! actual

[<Theory>]
[<InlineData(         0, "nul")>]
[<InlineData(         1, "et")>]
[<InlineData(         2, "to")>]
[<InlineData(         3, "tre")>]
[<InlineData(         4, "fire")>]
[<InlineData(         5, "fem")>]
[<InlineData(         6, "seks")>]
[<InlineData(         7, "syv")>]
[<InlineData(         8, "otte")>]
[<InlineData(         9, "ni")>]
[<InlineData(        10, "ti")>]
[<InlineData(        11, "elleve")>]
[<InlineData(        12, "tolv")>]
[<InlineData(        13, "tretten")>]
[<InlineData(        14, "fjorten")>]
[<InlineData(        15, "femten")>]
[<InlineData(        16, "seksten")>]
[<InlineData(        17, "sytten")>]
[<InlineData(        18, "atten")>]
[<InlineData(        19, "nitten")>]
[<InlineData(        20, "tyve")>]
[<InlineData(        21, "en-og-tyve")>]
[<InlineData(        30, "tredive")>]
[<InlineData(        34, "fire-og-tredive")>]
[<InlineData(        40, "fyrre")>]
[<InlineData(        42, "to-og-fyrre")>]
[<InlineData(        50, "halvtreds")>]
[<InlineData(        58, "otte-og-halvtreds")>]
[<InlineData(        60, "tres")>]
[<InlineData(        65, "fem-og-tres")>]
[<InlineData(        70, "halvfjerds")>]
[<InlineData(        79, "ni-og-halvfjerds")>]
[<InlineData(        80, "firs")>]
[<InlineData(        86, "seks-og-firs")>]
[<InlineData(        90, "halvfems")>]
[<InlineData(        93, "tre-og-halvfems")>]
[<InlineData(       100, "et-hundrede")>]
[<InlineData(       101, "et-hundrede-og-et")>]
[<InlineData(       110, "et-hundrede-og-ti")>]
[<InlineData(       114, "et-hundrede-og-fjorten")>]
[<InlineData(       135, "et-hundrede-fem-og-tredive")>]
[<InlineData(       200, "to-hundrede")>]
[<InlineData(       282, "to-hundrede-to-og-firs")>]
[<InlineData(       331, "tre-hundrede-en-og-tredive")>]
[<InlineData(       407, "fire-hundrede-og-syv")>]
[<InlineData(       520, "fem-hundrede-tyve")>]
[<InlineData(       666, "seks-hundrede-seks-og-tres")>]
[<InlineData(       798, "syv-hundrede-otte-og-halvfems")>]
[<InlineData(       857, "otte-hundrede-syv-og-halvtreds")>]
[<InlineData(       999, "ni-hundrede-ni-og-halvfems")>]
[<InlineData(      1000, "et-tusind")>]
[<InlineData(      1001, "et-tusind-og-et")>]
[<InlineData(      1010, "et-tusind-og-ti")>]
[<InlineData(      1066, "et-tusind-og-seks-og-tres")>]
[<InlineData(      1337, "et-tusind-tre-hundrede-syv-og-tredive")>]
[<InlineData(      1984, "et-tusind-ni-hundrede-fire-og-firs")>]
[<InlineData(      2015, "to-tusind-og-femten")>]
[<InlineData(      3000, "tre-tusind")>]
[<InlineData(      3297, "tre-tusind-to-hundrede-syv-og-halvfems")>]
[<InlineData(      4080, "fire-tusind-og-firs")>]
[<InlineData(      5011, "fem-tusind-og-elleve")>]
[<InlineData(      6025, "seks-tusind-og-fem-og-tyve")>]
[<InlineData(      7441, "syv-tusind-fire-hundrede-en-og-fyrre")>]
[<InlineData(      8513, "otte-tusind-fem-hundrede-og-tretten")>]
[<InlineData(      9000, "ni-tusind")>]
[<InlineData(     10000, "ti-tusind")>]
[<InlineData(     12001, "tolv-tusind-og-et")>]
[<InlineData(     23846, "tre-og-tyve-tusind-otte-hundrede-seks-og-fyrre")>]
[<InlineData(     32109, "to-og-tredive-tusind-et-hundrede-og-ni")>]
[<InlineData(     40404, "fyrre-tusind-fire-hundrede-og-fire")>]
[<InlineData(     52789, "to-og-halvtreds-tusind-syv-hundrede-ni-og-firs")>]
[<InlineData(     60015, "tres-tusind-og-femten")>]
[<InlineData(     71003, "en-og-halvfjerds-tusind-og-tre")>]
[<InlineData(     80522, "firs-tusind-fem-hundrede-to-og-tyve")>]
[<InlineData(     98962, "otte-og-halvfems-tusind-ni-hundrede-to-og-tres")>]
[<InlineData(    100000, "et-hundrede-tusind")>]
[<InlineData(    100001, "et-hundrede-tusind-og-et")>]
[<InlineData(    100010, "et-hundrede-tusind-og-ti")>]
[<InlineData(    101010, "et-hundrede-et-tusind-og-ti")>]
[<InlineData(    200000, "to-hundrede-tusind")>]
[<InlineData(    321000, "tre-hundrede-en-og-tyve-tusind")>]
[<InlineData(    412516, "fire-hundrede-tolv-tusind-fem-hundrede-og-seksten")>]
[<InlineData(    560120, "fem-hundrede-tres-tusind-et-hundrede-tyve")>]
[<InlineData(    600000, "seks-hundrede-tusind")>]
[<InlineData(    788000, "syv-hundrede-otte-og-firs-tusind")>]
[<InlineData(    872900, "otte-hundrede-to-og-halvfjerds-tusind-ni-hundrede")>]
[<InlineData(    908077, "ni-hundrede-otte-tusind-og-syv-og-halvfjerds")>]
[<InlineData(   1000000, "en-million")>]
[<InlineData(   2000002, "to-millioner-og-to")>]
[<InlineData(   3040506, "tre-millioner-fyrre-tusind-fem-hundrede-og-seks")>]
[<InlineData(   4321000, "fire-millioner-tre-hundrede-en-og-tyve-tusind")>]
[<InlineData(   5003621, "fem-millioner-tre-tusind-seks-hundrede-en-og-tyve")>]
[<InlineData(   5982001, "fem-millioner-ni-hundrede-to-og-firs-tusind-og-et")>]
[<InlineData(   6902001, "seks-millioner-ni-hundrede-to-tusind-og-et")>]
[<InlineData(   7000000, "syv-millioner")>]
[<InlineData(   8000220, "otte-millioner-to-hundrede-tyve")>]
[<InlineData(   9099000, "ni-millioner-ni-og-halvfems-tusind")>]
[<InlineData(  10000000, "ti-millioner")>]
[<InlineData(  24000000, "fire-og-tyve-millioner")>]
[<InlineData(  39020011, "ni-og-tredive-millioner-tyve-tusind-og-elleve")>]
[<InlineData(  40209100, "fyrre-millioner-to-hundrede-ni-tusind-et-hundrede")>]
[<InlineData(  53000000, "tre-og-halvtreds-millioner")>]
[<InlineData(  64000098, "fire-og-tres-millioner-og-otte-og-halvfems")>]
[<InlineData(  70003180, "halvfjerds-millioner-tre-tusind-et-hundrede-firs")>]
[<InlineData(  80000000, "firs-millioner")>]
[<InlineData(  99000099, "ni-og-halvfems-millioner-og-ni-og-halvfems")>]
[<InlineData( 100000000, "et-hundrede-millioner")>]
[<InlineData( 209000000, "to-hundrede-ni-millioner")>]
[<InlineData( 398000000, "tre-hundrede-otte-og-halvfems-millioner")>]
[<InlineData( 439012000, "fire-hundrede-ni-og-tredive-millioner-tolv-tusind")>]
[<InlineData( 560400000, "fem-hundrede-tres-millioner-fire-hundrede-tusind")>]
[<InlineData( 600010900, "seks-hundrede-millioner-ti-tusind-ni-hundrede")>]
[<InlineData( 700000000, "syv-hundrede-millioner")>]
[<InlineData( 800115000, "otte-hundrede-millioner-et-hundrede-femten-tusind")>]
[<InlineData( 900800007, "ni-hundrede-millioner-otte-hundrede-tusind-og-syv")>]
[<InlineData(1000000000, "en-milliard")>]
[<InlineData(1000000080, "en-milliard-og-firs")>]
[<InlineData(1000000120, "en-milliard-et-hundrede-tyve")>]
[<InlineData(2121000000, "to-milliarder-et-hundrede-en-og-tyve-millioner")>]
[<InlineData(
    System.Int32.MaxValue,
    "to-milliarder-et-hundrede-syv-og-fyrre-millioner-fire-hundrede-tre-og-firs-tusind-seks-hundrede-syv-og-fyrre")>]
let ``toDanish returns correct result`` (i, expected) =
    let actual = Numeral.toDanish i
    expected =! actual