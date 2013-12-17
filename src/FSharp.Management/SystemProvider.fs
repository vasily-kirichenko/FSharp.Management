﻿module FSharp.Management.TypeProviders.NamespaceProvider

open System.Reflection
open Microsoft.FSharp.Core.CompilerServices
open Samples.FSharp.ProvidedTypes
open System.Text.RegularExpressions
open FSharp.Management.TypeProviders.Helper

[<TypeProvider>]
/// [omit]
type public SystemProvider(cfg:TypeProviderConfig) as this =
    inherit TypeProviderForNamespaces()

    do this.AddNamespace(
        rootNamespace, 
        [FilesTypeProvider.createTypedFileSystem()
         RegistryProvider.createTypedRegistry()])

[<TypeProviderAssembly>]
do ()