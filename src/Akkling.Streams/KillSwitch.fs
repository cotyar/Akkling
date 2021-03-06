﻿//-----------------------------------------------------------------------
// <copyright file="KillSwitch.fs" company="Akka.NET Project">
//     Copyright (C) 2009-2015 Typesafe Inc. <http://www.typesafe.com>
//     Copyright (C) 2013-2015 Akka.NET project <https://github.com/akkadotnet/akka.net>
//     Copyright (C) 2015 Bartosz Sypytkowski <gttps://github.com/Horusiath>
// </copyright>
//-----------------------------------------------------------------------

namespace Akkling.Streams

open System
open Akkling
open Akka.Streams
open Akka.Streams.Dsl

[<RequireQualifiedAccess>]
module KillSwitch = 

    /// Creates a new SharedKillSwitch with the given name that can be used to control 
    /// the completion of multiple streams from the outside simultaneously.
    let inline shared name = KillSwitches.Shared(name)

    /// Creates a new shape of flow that materializes to an external switch that allows external completion
    /// of that unique materialization. Different materializations result in different, independent switches.
    let inline single<'t> = KillSwitches.Single<'t>()
     
    /// Creates a new shape of bidi flow that materializes to an external switch that allows external completion
    /// of that unique materialization. Different materializations result in different, independent switches.
    let inline singleBidi<'in1, 'out1> = KillSwitches.SingleBidi<'in1,'out1>() 