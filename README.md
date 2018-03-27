# Azure.Storage.Table.GetAzureTable

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-table-getazuretable.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/azure-storage-table-getazuretable)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Table.GetAzureTable.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Azure.Storage.Table.GetAzureTable)

## Description

Function returns a reference of a new or existing Microsoft Azure CloudTable using the environment's connection string and given table name

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Azure.Storage.Connection.GetConnectionString](https://github.com/CDorst/Azure.Storage.Connection.GetConnectionString) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-connection-getconnectionstring.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/azure-storage-connection-getconnectionstring) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Connection.GetConnectionString.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Azure.Storage.Connection.GetConnectionString)
[CDorst.Azure.Storage.Table.GetOrCreateTableReference](https://github.com/CDorst/Azure.Storage.Table.GetOrCreateTableReference) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-table-getorcreatetablereference.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/azure-storage-table-getorcreatetablereference) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Table.GetOrCreateTableReference.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Azure.Storage.Table.GetOrCreateTableReference)

## Dependents

The projects below use this repository as a direct dependency.

Name | Status
---- | ------
[DevOps.Build.AppVeyor.GetAzureTable](https://github.com/CDorst./DevOps.Build.AppVeyor.GetAzureTable) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst./devops-build-appveyor-getazuretable.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst./devops-build-appveyor-getazuretable) [![NuGet package status](https://img.shields.io/nuget/v/CDorst..DevOps.Build.AppVeyor.GetAzureTable.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst..DevOps.Build.AppVeyor.GetAzureTable)
[DevOps.Code.Entities.GetAzureTable](https://github.com/CDorst./DevOps.Code.Entities.GetAzureTable) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst./devops-code-entities-getazuretable.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst./devops-code-entities-getazuretable) [![NuGet package status](https://img.shields.io/nuget/v/CDorst..DevOps.Code.Entities.GetAzureTable.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst..DevOps.Code.Entities.GetAzureTable)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Azure.Storage.Table.GetAzureTable](https://www.nuget.org/packages/CDorst.Azure.Storage.Table.GetAzureTable)

## Version

4.0.7

## Metaproject

Azure.Storage.Table.GetAzureTable is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

